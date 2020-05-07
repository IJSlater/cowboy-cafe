using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public  IEnumerable<IOrderItem> entrees =Menu.Entrees();
        public IEnumerable<IOrderItem> sides = Menu.Sides();
        public IEnumerable<IOrderItem> drinks = Menu.Drinks();
        public string SearchTerms { get; set; } = "Search for Item";
        public string EntreeCheck { get; set; }
        public string DrinkCheck { get; set; }
        public string SideCheck { get; set; }
        public string MinCal { get; set; } = "0";
        public string MaxCal { get; set; } = "900";
        public string MinPrice { get; set; } = "0.00";
        public string MaxPrice { get; set; } = "50.00";




        public void OnGet()
        {

        }

        public void OnPost()
        {

            entrees = Menu.Entrees();
            sides = Menu.Sides();
            drinks = Menu.Drinks();

            if (Request.Form["EntreeCheck"] == "on")
                EntreeCheck = "checked";
            else
            {
                EntreeCheck = null;
            }

            if (Request.Form["SideCheck"] == "on")
                SideCheck = "checked";
            else
            {
                SideCheck = null;
            }

            if (Request.Form["DrinkCheck"] == "on")
                DrinkCheck = "checked";
            else
            {
                DrinkCheck = null;
            }
            SearchTerms = Request.Form["SearchTerms"];
            MinCal = Request.Form["MinCalories"];
            MaxCal = Request.Form["MaxCalories"];
            MinPrice = Request.Form["MinPrice"];
            MaxPrice = Request.Form["MaxPrice"];
            string hold = Request.Form["SearchTerms"];
            if(EntreeCheck!=null)
                entrees = from item in Menu.Entrees()
                          where item.ToString().ToLower().Contains(hold.ToLower()) && item.Calories >= Convert.ToUInt32(Request.Form["MinCalories"]) && item.Calories <= Convert.ToUInt32(Request.Form["MaxCalories"]) && item.Price >= Convert.ToDouble(Request.Form["MinPrice"]) && item.Price <= Convert.ToDouble(Request.Form["MaxPrice"])
                          select item;
              if (DrinkCheck != null)
                drinks = from item in Menu.Drinks()
                     where item.ToString().Contains(hold.ToLower()) && item.Calories >= Convert.ToUInt32(Request.Form["MinCalories"]) && item.Calories <= Convert.ToUInt32(Request.Form["MaxCalories"]) && item.Price >= Convert.ToDouble(Request.Form["MinPrice"]) && item.Price <= Convert.ToDouble(Request.Form["MaxPrice"])
                      select item;

            if (SideCheck != null)
                sides = from item in Menu.Sides()
                      where item.ToString().Contains(hold.ToLower()) && item.Calories >= Convert.ToUInt32(Request.Form["MinCalories"]) && item.Calories <= Convert.ToUInt32(Request.Form["MaxCalories"]) && item.Price >= Convert.ToDouble(Request.Form["MinPrice"]) && item.Price <= Convert.ToDouble(Request.Form["MaxPrice"])
                      select item;
        }
    }
}
