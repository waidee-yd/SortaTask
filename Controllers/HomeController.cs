using Microsoft.AspNetCore.Mvc;
using SortaTask.Models;
using System.Diagnostics;

namespace SortaTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dashboard ()
        {
            var username = HttpContext.Session.GetString ("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction ("Login", "Account");
            }

            ViewBag.Username = username;
            return View ();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
