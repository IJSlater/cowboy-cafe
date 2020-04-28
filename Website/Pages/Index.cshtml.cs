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



        public string SearchTerms { get; set; } = "Search for Item";
        public bool EntreeCheck { get; set; }
        public bool DrinkCheck { get; set; }
        public bool SideCheck { get; set; }
        public uint MinCal { get; set; }
        public uint MaxCal { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }


        public  List<IOrderItem> Entrees;
        public  List<IOrderItem> Sides;
        public  List<IOrderItem> Drinks;


        public void OnGet()
        {

            SearchTerms = Request.Form.ToString();
            //Entrees
            

        }
    }
}
