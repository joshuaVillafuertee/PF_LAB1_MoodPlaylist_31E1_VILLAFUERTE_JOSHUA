using Microsoft.AspNetCore.Mvc;

namespace MoodPlaylist.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
