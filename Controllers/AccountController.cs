using Microsoft.AspNetCore.Mvc;
using SortaTask.Models;

namespace SortaTask.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet] 
        public IActionResult Login ()
        {
            return View ();
        }

        [HttpPost]
        public IActionResult Login(string username, string password) 
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                HttpContext.Session.SetString ("Username", username);
                return RedirectToAction ("Dashboard", "Home");
            }

            ViewBag.Error = "Please enter a username."; 
            return View ();
        }

        [HttpGet]
        public IActionResult Register ()
        {
            return View ();
        }

        [HttpPost]
        public IActionResult Register (string username, string email, string password, string confirmPassword)
        {
            if (!string.IsNullOrWhiteSpace(username) 
            && !string.IsNullOrWhiteSpace(email)
            && !string.IsNullOrWhiteSpace(password)
            && !string.IsNullOrWhiteSpace(confirmPassword))
            {
                HttpContext.Session.SetString ("Username", username);
                return RedirectToAction ("Dashboard", "Home");
            }

            ViewBag.Error = "All fields are required."; 
            return View ();
        }
        
        [HttpPost] 
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction ("Login", "Account");
        }
    }
}