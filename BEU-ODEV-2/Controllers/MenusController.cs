using BEU_ODEV_2.Data;
using BEU_ODEV_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BEU_ODEV_2.Controllers
{
    public class MenusController : Controller
    {

        private readonly ApplicationDbContext _db;
        public MenusController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IList<Menus> contents = _db.Menus.ToList();
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Menus o)
        {
            if (ModelState.IsValid)
            {
                _db.Add(o);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }

        }
    }
}
