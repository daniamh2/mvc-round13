using KaShop.Data;
using KaShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KaShop.Areas.admin.Controllers
{
    [Area("admin")]
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            //    var products = context.Products.Join(context.Categories,  p => p.CategoryId , c => c.Id ,
            //        (p,c) => new
            //        {
            //            prodId = p.Id,
            //            prodName = p.Name,
            //            categoryName = c.Name
            //        }).ToList();


        var products = context.Products.Include(p => p.Category).ToList();
        //                        <td>@product.Category.Name</td>
            return View(products);
        }
        public IActionResult Create() 
        { 
             ViewBag.Categories = context.Categories.ToList();
            return View(  new Product() { });
        
        }
        public IActionResult Store(Product request, IFormFile Image)
        {

            if (Image != null && Image.Length > 0) {

                var filName = Guid.NewGuid().ToString();
                filName += Path.GetExtension(Image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images" , filName);

                using (var stream = System.IO.File.Create(filePath))
                {
                    Image.CopyTo(stream);// to store image in the path
                }

                request.Image = filName;
                context.Products.Add(request);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return Content("ok");
        }

    }
}
