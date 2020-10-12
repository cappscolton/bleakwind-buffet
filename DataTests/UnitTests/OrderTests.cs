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
            x.Add(new BriarheartBurger());
            Assert.PropertyChanged(x, "Subtotal", () =>
            {
                x.Remove(new BriarheartBurger());
            });
        }

        [Fact]
        public void RemovingItemRaisesTotalPropertyChanged()
        {
            Order x = new Order();
            x.Add(new BriarheartBurger());
            Assert.PropertyChanged(x, "Total", () =>
            {
                x.Remove(new BriarheartBurger());
            });
        }

        [Fact]
        public void RemovingItemRaisesTaxPropertyChanged()
        {
            Order x = new Order();
            x.Add(new BriarheartBurger());
            Assert.PropertyChanged(x, "Tax", () =>
            {
                x.Remove(new BriarheartBurger());
            });
        }

        [Fact]
        public void RemovingItemRaisesCaloriesPropertyChanged()
        {
            Order x = new Order();
            x.Add(new BriarheartBurger());
            Assert.PropertyChanged(x, "Calories", () =>
            {
                x.Remove(new BriarheartBurger());
            });
        }

        [Fact]
        public void ChangingItemPriceRaisesPropertyChanged()
        {
            Order x = new Order();
            x.Add(new AretinoAppleJuice());
            Assert.PropertyChanged(x, "Subtotal", () =>
            {
                AretinoAppleJuice b = x[1] as AretinoAppleJuice;
                b.Size = Size.Large;
            });

            Assert.PropertyChanged(x, "Tax", () =>
            {
                AretinoAppleJuice b = x[1] as AretinoAppleJuice;
                b.Size = Size.Large;
            });
            Assert.PropertyChanged(x, "Total", () =>
            {
                AretinoAppleJuice b = x[1] as AretinoAppleJuice;
                b.Size = Size.Large;
            });

        }

        [Fact]
        public void ChangingItemCaloriesRaisesPropertyChanged()
        {
            Order x = new Order();
            x.Add(new AretinoAppleJuice());
            Assert.PropertyChanged(x, "Subtotal", () =>
            {
                AretinoAppleJuice b = x[1] as AretinoAppleJuice;
                b.Size = Size.Large;
            });

            Assert.PropertyChanged(x, "Tax", () =>
            {
                AretinoAppleJuice b = x[1] as AretinoAppleJuice;
                b.Size = Size.Large;
            });
            Assert.PropertyChanged(x, "Total", () =>
            {
                AretinoAppleJuice b = x[1] as AretinoAppleJuice;
                b.Size = Size.Large;
            });

        }




    }
}
