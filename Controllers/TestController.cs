using Microsoft.AspNetCore.Mvc;

namespace MoodPlaylist.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return Content("TestController is working!");
        }
    }
}
