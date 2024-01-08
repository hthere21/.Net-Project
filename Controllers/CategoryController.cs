using Microsoft.AspNetCore.Mvc;
using Project_.Net_6.Data;
using Project_.Net_6.Models;

namespace Project_.Net_6.Controllers
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
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
