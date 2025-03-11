// CHANGE HISTORY
// DATE         NAME                DESCRIPTION
// 03-04-2025   adorog12@uw.edu     Add in ViewData information created in the Privacy.cshtml
//                                  into IActionResult Privacy().
// 03-06-2025   adorog12@uw.edu     Add an About() with text display. Add parameters to
//                                  Privacy() method.

using System.Diagnostics;
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy(string first, string last, string email)
        {
            ViewData["FirstName"] = "Chuck";
            ViewData["LastName"] = "Costarella";
            ViewData["Email"] = "costarec@contosou.edu";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
