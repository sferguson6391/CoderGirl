using System.Collections.Generic;
using CG.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CG.ViewModels;

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
            AddEditCheeseViewModel addCheeseViewModel = new AddEditCheeseViewModel();
            return View(addCheeseViewModel);
        }


        public IActionResult Remove()
        {
            return View(CheeseData.GetAll());
        }

        [HttpPost]
        //[Route("/Cheese/Add")]
        public IActionResult Add(AddEditCheeseViewModel addCheeseViewModel)
        {
            if (ModelState.IsValid)
            {
                Cheese newCheese = new Cheese()
                {
                    Name = addCheeseViewModel.Name,
                    Description = addCheeseViewModel.Description,
                    Type = addCheeseViewModel.Type,
                    Rating = (int)addCheeseViewModel.Rating
                };

                CheeseData.Add(newCheese);

                return Redirect("/Cheese");
            }

            return View(addCheeseViewModel);
        }

        [HttpPost]
        //[Route("/Cheese/Remove")]
        public IActionResult Remove(int[] cheeseIds)
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