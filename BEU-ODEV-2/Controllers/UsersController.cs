using BEU_ODEV_2.Data;
using BEU_ODEV_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BEU_ODEV_2.Controllers
{
    public class UsersController : Controller
    {

        private readonly ApplicationDbContext _db;
        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IList<Users> contents = _db.Users.ToList();
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Users o)
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
