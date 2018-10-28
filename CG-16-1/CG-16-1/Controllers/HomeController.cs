using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CG_16_1.Models;

namespace CG_16_1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[Route("/Index")]
        public IActionResult Index(string firstName, string language)
        {
            if (string.IsNullOrEmpty(firstName))
                return Content("A first name is required.");
            else if (language == "english")
                return Content($"Hello {firstName}!");
            else if (language == "spanish")
                return Content($"Hola {firstName}!");
            else if (language == "french")
                return Content($"Bonjour {firstName}!");
            else if (language == "german")
                return Content($"Hallo {firstName}!");
            else if (language == "italian")
                return Content($"Ciao {firstName}!");
            else return null;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
