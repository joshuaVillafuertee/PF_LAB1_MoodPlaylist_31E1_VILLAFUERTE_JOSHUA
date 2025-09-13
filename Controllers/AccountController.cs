using Microsoft.AspNetCore.Mvc;
using MoodPlaylist.SQLite.Services;
using MoodPlaylist.Web.ViewModels;

namespace MoodPlaylist.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthService _authService;

        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(AuthViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _authService.Authenticate(model.Username, model.Password);
                if (user != null)
                {
                    // TODO: add cookie/session auth
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid login attempt.");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(AuthViewModel model)
        {
            if (ModelState.IsValid)
            {
                _authService.Register(model.Username, model.Password);
                return RedirectToAction("Login");
            }
            return View(model);
        }
    }
}
