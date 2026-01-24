using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Areas.admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
