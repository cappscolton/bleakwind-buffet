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
        }

        /// <summary>
        /// Holds values of categories of menu items to display. Can hold "Entrees" "Sides" and "Drinks" as values.
        /// </summary>
        public string[] MenuTypes { get; set; }

        /// <summary>
        /// List of IOrderItem entrees to be dispalyed
        /// </summary>
        public List<IOrderItem> Entrees { get; set; }

        /// <summary>
        /// List of IOrderItem drinks to be dispalyed
        /// </summary>
        public List<IOrderItem> Drinks { get; set; }

        /// <summary>
        /// List of IOrderItem sides to be dispalyed
        /// </summary>
        public List<IOrderItem> Sides { get; set; }

        /// <summary>
        /// Minimum calorie value to filter
        /// </summary>
        [BindProperty(SupportsGet =true)]
        public double? CaloriesMin { get; set; }

        /// <summary>
        /// Maximum calorie value to filter
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? CaloriesMax { get; set; }

        /// <summary>
        /// Minimum price value to filter
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// Maximum price value to filter
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        /// <summary>
        /// String search terms to filter
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Runs every time the page is refreshed or the form is submitted. Runs each filter and search function and assigns the menu items to be displayed
        /// </summary>
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
    }
}
