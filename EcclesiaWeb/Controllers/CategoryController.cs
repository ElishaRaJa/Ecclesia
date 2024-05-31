using Microsoft.AspNetCore.Mvc;
using EcclesiaWeb.Data;
using EcclesiaWeb.Models;

namespace EcclesiaWeb.Controllers
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
            // goes to db andfest and makes list
            List<Category> objCategoryList = _db.Categories.ToList();

            return View(objCategoryList);
        }


        // ---Actions

        //create
    }
}
