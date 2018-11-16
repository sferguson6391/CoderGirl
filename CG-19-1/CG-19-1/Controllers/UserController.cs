using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CG.Models;
using Microsoft.AspNetCore.Mvc;

namespace CG_19_1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            User newUser = new User();
            return View(newUser);
        }

        [HttpPost]
        public IActionResult Add(User newUser, string verify)
        {
            if (verify == newUser.Password)
            {
                return RedirectToAction("Index", "User", new { newUser });
            }

            return Redirect("/Add");
        }
    }
}