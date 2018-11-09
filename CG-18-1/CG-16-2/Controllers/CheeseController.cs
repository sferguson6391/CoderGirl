using System.Collections.Generic;
using CG.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CG_16_2.Controllers
{
    public class CheeseController : Controller
    {
        public IActionResult Index()
        {
            return View(CheeseData.GetAll());
        }

        public IActionResult Add()
        {
            return View();
        }


        public IActionResult Remove()
        {
            return View(CheeseData.GetAll());
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(Cheese newCheese)
        {
            CheeseData.Add(newCheese);

            return Redirect("/Cheese");
        }

        [HttpPost]
        [Route("/Cheese/Remove")]
        public IActionResult RemoveCheese(int[] cheeseIds)
        {
            foreach (int cheeseId in cheeseIds)
            {
                CheeseData.Remove(cheeseId);
            }

            return Redirect("/Cheese");
        }

        public IActionResult Edit(int cheeseId)
        {
            return View(CheeseData.GetById(cheeseId));
        }

        //query CheeseData for the cheese with the given id, and then update its name and 
        //description. Redirect the user to the home page.
        [HttpPost]
        public IActionResult Edit(int cheeseId, string name, string description)
        {
            var myCheese = CheeseData.GetById(cheeseId);

            myCheese.Name = name;
            myCheese.Description = description;

            return Redirect("/Cheese");
        }
    }
}