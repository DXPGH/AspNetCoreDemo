using AspNetCoreDemo.Data;
using AspNetCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            // SELECT * FROM CATEGORIES;
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
