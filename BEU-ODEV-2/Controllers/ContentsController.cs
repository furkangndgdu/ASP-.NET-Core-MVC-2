using BEU_ODEV_2.Data;
using BEU_ODEV_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BEU_ODEV_2.Controllers
{
    public class ContentsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ContentsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IList<Contents> contents = _db.contents.ToList();
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Contents o)
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
