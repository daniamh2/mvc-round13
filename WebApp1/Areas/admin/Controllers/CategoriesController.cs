using KaShop.Data;
using KaShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace KaShop.Areas.admin.Controllers
{
    [Area("admin")]
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Store(Category request)
        {
            if (ModelState.IsValid)
            {
                var category = context.Categories.Add(request);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View("Create", request);
        }
        public IActionResult Remove(int id)
        {
            var category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var category = context.Categories.Find(id);
            return View(category);

        }
        public IActionResult Update(Category request, int id) {
            if (ModelState.IsValid)
            {
                context.Categories.Update(request);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View("Edit",request);
        }
    }
}