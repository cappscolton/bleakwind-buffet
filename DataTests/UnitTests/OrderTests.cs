using Xunit;
using System;
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
    public class OrderTests
    {
        [Fact]
        public void AddingAnItemShouldTriggerCollectionChanged()
        {
            Order o = new Order();
            o.Add(new BriarheartBurger());
        }

        [Fact]
        public void AddingItemRaisesSubtotalPropertyChanged()
        {
            Order x = new Order();
            Assert.PropertyChanged(x, "Subtotal", () =>
            {
                x.Add(new BriarheartBurger());
            });
        }

        [Fact]
        public void AddingItemRaisesTotalPropertyChanged()
        {
            Order x = new Order();
            Assert.PropertyChanged(x, "Total", () =>
            {
                x.Add(new BriarheartBurger());
            });
        }

        [Fact]
        public void AddingItemRaisesTaxPropertyChanged()
        {
            Order x = new Order();
            Assert.PropertyChanged(x, "Tax", () =>
            {
                x.Add(new BriarheartBurger());
            });
        }

        [Fact]
        public void AddingItemRaisesCaloriesPropertyChanged()
        {
            Order x = new Order();
            Assert.PropertyChanged(x, "Calories", () =>
            {
                x.Add(new BriarheartBurger());
            });
        }

        [Fact]
        public void RemovingItemRaisesSubtotalPropertyChanged()
        {
            Order x = new Order();
            BriarheartBurger b = new BriarheartBurger();
            x.Add(b);
            Assert.PropertyChanged(x, "Subtotal", () =>
            {
                x.Remove(b);
            });
        }

        [Fact]
        public void RemovingItemRaisesTotalPropertyChanged()
        {
            Order x = new Order();
            BriarheartBurger b = new BriarheartBurger();
            x.Add(b);
            Assert.PropertyChanged(x, "Total", () =>
            {
                x.Remove(b);
            });
        }

        [Fact]
        public void RemovingItemRaisesTaxPropertyChanged()
        {
            Order x = new Order();
            BriarheartBurger b = new BriarheartBurger();
            x.Add(b);
            Assert.PropertyChanged(x, "Tax", () =>
            {
                x.Remove(b);
            });
        }

        [Fact]
        public void RemovingItemRaisesCaloriesPropertyChanged()
        {
            Order x = new Order();
            BriarheartBurger b = new BriarheartBurger();
            x.Add(b);
            Assert.PropertyChanged(x, "Calories", () =>
            {
                x.Remove(b);
            });
        }

        [Fact]
        public void ChangingItemPriceRaisesPropertyChanged()
        {
            Order x = new Order();
            AretinoAppleJuice a = new AretinoAppleJuice();
            x.Add(a);
            Assert.PropertyChanged(x, "Subtotal", () =>
            {
                a.Size = Size.Large;
            });

            Assert.PropertyChanged(x, "Tax", () =>
            {
                a.Size = Size.Medium;
            });
            Assert.PropertyChanged(x, "Total", () =>
            {
                a.Size = Size.Small;
            });

        }

        [Fact]
        public void ChangingItemCaloriesRaisesPropertyChanged()
        {
            Order x = new Order();
            AretinoAppleJuice a = new AretinoAppleJuice();
            x.Add(a);
            Assert.PropertyChanged(x, "Calories", () =>
            {
                a.Size = Size.Large;
            });

        }




    }
}
