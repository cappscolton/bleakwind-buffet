using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            MenuTypes = new string[] { "Entrees", "Sides", "Drinks" };
        }

        public string[] MenuTypes { get; set; }

        public List<IOrderItem> Entrees { get; set; }

        public List<IOrderItem> Drinks { get; set; }

        public List<IOrderItem> Sides { get; set; }

        [BindProperty(SupportsGet =true)]
        public double CaloriesMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public double CaloriesMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public double PriceMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public double PriceMax { get; set; }

        public string SearchTerms { get; set; }


        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            MenuTypes = Request.Query["MenuTypes"];
            List<List<IOrderItem>> menu = Menu.Search(SearchTerms);
            menu = Menu.FilterByMenuType(menu, MenuTypes);
            menu = Menu.FilterByCalories(menu, CaloriesMin, CaloriesMax);
            menu = Menu.FilterByPrice(menu, PriceMin, PriceMax);
            Entrees = menu[0];
            Sides = menu[1];
            Drinks = menu[2];
        }

        public int sodas = 0;
    }
}
