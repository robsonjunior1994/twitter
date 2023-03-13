using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTwitter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Feed()
        {
            return View();
        }
    }
}
