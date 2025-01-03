using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{

    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Account model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "admin" && model.Password == "admin")
                {
                    // Authentication successful
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Authentication failed
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }

            return View(model);
        }
    }
}