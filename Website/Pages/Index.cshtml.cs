using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public  List<IOrderItem> entrees =(List<IOrderItem>)Menu.Entrees();
        public List<IOrderItem> sides = (List<IOrderItem>)Menu.Sides();
        public List<IOrderItem> drinks = (List<IOrderItem>)Menu.Drinks();
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

            entrees = (List<IOrderItem>)Menu.Entrees();
            sides = (List<IOrderItem>)Menu.Sides();
            drinks = (List<IOrderItem>)Menu.Drinks();

            if (Request.Form["EntreeCheck"] == "on")
                EntreeCheck = "checked";
            else
            {
                EntreeCheck = null;
            }

            if (Request.Form["SideCheck"] == "on")
                EntreeCheck = "checked";
            else
            {
                SideCheck = null;
            }

            if (Request.Form["DrinkCheck"] == "on")
                EntreeCheck = "checked";
            else
            {
                DrinkCheck = null;
            }
            SearchTerms = Request.Form["SearchTerms"];
            MinCal = Request.Form["MinCalories"];
            MaxCal = Request.Form["MaxCalories"];
            MinPrice = Request.Form["MinPrice"];
            MaxPrice = Request.Form["MaxPrice"];



            entrees = Menu.FilterEntrees(Request.Form["EntreeCheck"], Request.Form["SearchTerms"], Request.Form["MinCalories"], Request.Form["MaxCalories"], Request.Form["MinPrice"], Request.Form["MaxPrice"]);
            sides = Menu.FilterSides(Request.Form["SideCheck"], Request.Form["SearchTerms"], Request.Form["MinCalories"], Request.Form["MaxCalories"], Request.Form["MinPrice"], Request.Form["MaxPrice"]);
            drinks = Menu.FilterDrinks(Request.Form["DrinkCheck"], Request.Form["SearchTerms"], Request.Form["MinCalories"], Request.Form["MaxCalories"], Request.Form["MinPrice"], Request.Form["MaxPrice"]);


        }
    }
}
