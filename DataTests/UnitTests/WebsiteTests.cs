using Xunit;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class WebsiteTests
    {
        [Theory]
        [InlineData("Small")]
        [InlineData("Medium")]
        [InlineData("Large")]
        [InlineData("Smokehouse Skeleton")]
        public void TextFilteredMenuShouldIncludeText(string s)
        {
            string[] terms = s.ToLower().Split();
            List<List<IOrderItem>> items = Menu.Search(s);
            foreach (List<IOrderItem> l in items)
            {
                foreach(IOrderItem i in l)
                {
                    Assert.True(terms.Any(i.Description.ToLower().Contains) || terms.Any(i.ToString().ToLower().Contains));
                }
            }
        }

        [Fact]
        public void NoSearchParameterShouldReturnFullMenu()
        {
            List<List<IOrderItem>> menu = Menu.Search(null);
            IEnumerable<IOrderItem> entrees = Menu.Entrees();
            
            foreach (IOrderItem i in entrees)
            {
                bool contains = false;
                foreach(IOrderItem i2 in menu[0])
                {
                    if (i.ToString() == i2.ToString()) contains = true;
                }
                Assert.True(contains);
            }
            IEnumerable<IOrderItem> drinks = Menu.Drinks();
            foreach (IOrderItem i in drinks)
            {
                bool contains = false;
                foreach(IOrderItem i2 in menu[2])
                {
                    if (i.ToString() == i2.ToString()) contains = true;
                }
                Assert.True(contains);
            }
            IEnumerable<IOrderItem> sides = Menu.Sides();
            foreach (IOrderItem i in sides)
            {
                bool contains = false;
                foreach (IOrderItem i2 in menu[1])
                {
                    if (i.ToString() == i2.ToString()) contains = true;
                }
                Assert.True(contains);
            }
        }

        [Theory]
        [InlineData(0, 500)]
        [InlineData(200, 500)]
        [InlineData(0, 1000)]
        [InlineData(500, 1000)]
        public void CalorieFilteredMenuItemsShouldHaveValidCalories(double minimum, double maximum)
        {
            List<List<IOrderItem>> menu = Menu.Search(null);
            menu = Menu.FilterByCalories(menu, minimum, maximum);
            foreach (List<IOrderItem> l in menu)
            {
                foreach(IOrderItem i in l)
                {
                    Assert.True(i.Calories > minimum);
                    Assert.True(i.Calories < maximum);
                }
            }
        }

        [Theory]
        [InlineData(0.0, 5.0)]
        [InlineData(5.0, 10.0)]
        [InlineData(15.0, 20.0)]
        public void PriceFilteredMenuItemsShouldHaveValidPrices(double minimum, double maximum)
        {
            List<List<IOrderItem>> menu = Menu.Search(null);
            menu = Menu.FilterByPrice(menu, minimum, maximum);
            foreach (List<IOrderItem> l in menu)
            {
                foreach (IOrderItem i in l)
                {
                    Assert.True(i.Price > minimum);
                    Assert.True(i.Price < maximum);
                }
            }
        }

    }
}
