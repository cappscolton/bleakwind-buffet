using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class representing a menu of food and drink items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Creates a list of entrees on the menu
        /// </summary>
        /// <returns>IEnumerable of Entrees casted as IOrderItems</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new DoubleDraugr());
            list.Add(new GardenOrcOmelette());
            list.Add(new PhillyPoacher());
            list.Add(new SmokehouseSkeleton());
            list.Add(new ThalmorTriple());
            list.Add(new ThugsTBone());
            return list;
        }
        /// <summary>
        /// Creates a list of sides on the menu
        /// </summary>
        /// <returns>IEnumerable of sides casted as IOrderItems</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            Array x = Enum.GetValues(typeof(Size));
            foreach (Size s in x)
            {
                list.Add(new DragonbornWaffleFries() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new FriedMiraak() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new MadOtarGrits() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new VokunSalad() { Size = s });
            }

            return list;
        }
        /// <summary>
        /// Creates a list of drinks on the menu
        /// </summary>
        /// <returns>IEnumerable of drinks casted as IOrderItems</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            Array x = Enum.GetValues(typeof(Size));
            foreach (Size s in x)
            {
                list.Add(new AretinoAppleJuice() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new CandlehearthCoffee() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new MarkarthMilk() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new WarriorWater() { Size = s });
            }

            foreach (SodaFlavor f in Enum.GetValues(typeof(SodaFlavor)))
            {
                foreach (Size s in Enum.GetValues(typeof(Size)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = s;
                    ss.Flavor = f;
                    list.Add(ss);
                }
            }

            return list;
        }
        /// <summary>
        /// Creates a list of all items on the menu
        /// </summary>
        /// <returns>IEnumerable of entrees, drinks, and sides casted as IOrderItems</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            return Entrees().Concat(Sides()).Concat(Drinks());
        }

        /// <summary>
        /// Filters menu items for website based on Text search terms
        /// </summary>
        /// <param name="s">terms entered by user</param>
        /// <returns>List of Lists of IOrderItem. First list is entrees, second is sides, thrid is drinks.</returns>
        public static List<List<IOrderItem>> Search(string s)
        {
            if (s == null) return new List<List<IOrderItem>> { Entrees().ToList(), Sides().ToList(), Drinks().ToList() };

            string term = s.ToLower();
            string[] terms = term.Split();

            IEnumerable<IOrderItem> entrees = Menu.Entrees().Where(item => terms.Any(item.ToString().ToLower().Contains) || terms.Any(item.Description.ToLower().Contains));
            IEnumerable<IOrderItem> drinks = Menu.Drinks().Where(item => terms.Any(item.ToString().ToLower().Contains) || terms.Any(item.Description.ToLower().Contains));
            IEnumerable<IOrderItem> sides = Menu.Sides().Where(item => terms.Any(item.ToString().ToLower().Contains) || terms.Any(item.Description.ToLower().Contains));

            return new List<List<IOrderItem>> { entrees.ToList(), sides.ToList(), drinks.ToList() };
        }

        /// <summary>
        /// Filters results to be displayed on website menu based on the type of the item
        /// </summary>
        /// <param name="menu">Menu based on previous filters/terms</param>
        /// <param name="types">Strings that specify types of itesm to be displayed</param>
        /// <returns>List of Lists of IOrderItem. First list is entrees, second is sides, thrid is drinks.</returns>
        public static List<List<IOrderItem>> FilterByMenuType(List<List<IOrderItem>> menu, string[] types)
        {
            if (types == null || types.Count() == 0) return menu;

            menu[0] = menu[0].Where(item => types.Contains("Entrees")).ToList();
            menu[1] = menu[1].Where(item => types.Contains("Sides")).ToList();
            menu[2] = menu[2].Where(item => types.Contains("Drinks")).ToList();

            return menu;
        }

        /// <summary>
        /// Filters results to be displayed on website menu based on the calories of the item
        /// </summary>
        /// <param name="menu">Menu based on previous filters/terms</param>
        /// <param name="CaloriesMin">Min calories</param>
        /// <param name="CaloriesMax">Max calires</param>
        /// <returns>List of Lists of IOrderItem. First list is entrees, second is sides, thrid is drinks.</returns>
        public static List<List<IOrderItem>> FilterByCalories(List<List<IOrderItem>> menu, double? CaloriesMin, double? CaloriesMax)
        {
            if (CaloriesMin == null && CaloriesMax == null) return menu;
            if (CaloriesMin > 0 && CaloriesMax == null) CaloriesMax = 10000;

            menu[0] = menu[0].Where(item => item.Calories > CaloriesMin && item.Calories < CaloriesMax).ToList();
            menu[1] = menu[1].Where(item => item.Calories > CaloriesMin && item.Calories < CaloriesMax).ToList();
            menu[2] = menu[2].Where(item => item.Calories > CaloriesMin && item.Calories < CaloriesMax).ToList();

            return menu;

        }

        /// <summary>
        /// Filters results to be displayed on website menu based on the price of the item
        /// </summary>
        /// <param name="menu">Menu based on previous filters/terms</param>
        /// <param name="PriceMin">Minimum item price</param>
        /// <param name="PriceMax">Max item price</param>
        /// <returns>List of Lists of IOrderItem. First list is entrees, second is sides, thrid is drinks.</returns>
        public static List<List<IOrderItem>> FilterByPrice(List<List<IOrderItem>> menu, double? PriceMin, double? PriceMax)
        {
            if (PriceMin == null && PriceMax == null) return menu;
            if (PriceMin > 0 && PriceMax == null) PriceMax = 10000;

            menu[0] = menu[0].Where(item => item.Price > PriceMin && item.Price < PriceMax).ToList();
            menu[1] = menu[1].Where(item => item.Price > PriceMin && item.Price < PriceMax).ToList();
            menu[2] = menu[2].Where(item => item.Price > PriceMin && item.Price < PriceMax).ToList();

            return menu;

        }
    }
}
