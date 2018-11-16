using CG.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CG.ViewModels
{
    public class AddEditCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description")]
        public string Description { get; set; }

        public CheeseType Type { get; set; }
        public CheeseRating Rating { get; set; }

        public List<SelectListItem> CheeseTypes { get; set; }
        public List<SelectListItem> CheeseRatings { get; set; }

        public AddEditCheeseViewModel()
        {
            CheeseTypes = new List<SelectListItem>();

            CheeseTypes.Add(new SelectListItem {
                Value = ((int)CheeseType.Hard).ToString(),
                Text = CheeseType.Hard.ToString()
            });

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Soft).ToString(),
                Text = CheeseType.Soft.ToString()
            });

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Fake).ToString(),
                Text = CheeseType.Fake.ToString()
            });

            CheeseRatings = new List<SelectListItem>();

            CheeseRatings.Add(new SelectListItem
            {
                Value = ((int)CheeseRating.first).ToString(),
                Text = ((int)CheeseRating.first).ToString()
            });

            CheeseRatings.Add(new SelectListItem
            {
                Value = ((int)CheeseRating.second).ToString(),
                Text = ((int)CheeseRating.second).ToString()
            });

            CheeseRatings.Add(new SelectListItem
            {
                Value = ((int)CheeseRating.third).ToString(),
                Text = ((int)CheeseRating.third).ToString()
            });

            CheeseRatings.Add(new SelectListItem
            {
                Value = ((int)CheeseRating.fourth).ToString(),
                Text = ((int)CheeseRating.fourth).ToString()
            });

            CheeseRatings.Add(new SelectListItem
            {
                Value = ((int)CheeseRating.fifth).ToString(),
                Text = ((int)CheeseRating.fifth).ToString()
            });
        }
    }
}
