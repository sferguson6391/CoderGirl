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
        public IActionResult Index(User newUser)
        {
            return View(newUser);
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
                return View("Add", newUser);
            }

            return Redirect("/Add");
        }
    }
}