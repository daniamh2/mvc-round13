using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Areas.user.Controllers
{
    [Area("user")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
