using KaShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KaShop.Areas.user.Controllers
{       
    [Area("user")]

    public class Products : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IActionResult Index()
        {
            var products = context.Products
                                  .Include(p => p.Category)
                                  .ToList();

            return View(products);
        }
    }
}
