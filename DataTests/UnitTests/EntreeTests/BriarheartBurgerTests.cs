﻿/*
 * Author: Colton Capps
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using System.ComponentModel;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            BriarheartBurger x = new BriarheartBurger();
            Assert.Equal("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.", x.Description);
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            BriarheartBurger aj = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void ChangingPropertiesNotifiesSpecialInstructionsProperty()
        {
            var x = new BriarheartBurger();

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Bun = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Cheese = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Ketchup = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Pickle = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Mustard = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            BriarheartBurger x = new BriarheartBurger();

            Assert.PropertyChanged(x, "Bun", () =>
            {
                x.Bun = false;
            });
            Assert.PropertyChanged(x, "Bun", () =>
            {
                x.Bun = true;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            BriarheartBurger x = new BriarheartBurger();

            Assert.PropertyChanged(x, "Ketchup", () =>
            {
                x.Ketchup = false;
            });
            Assert.PropertyChanged(x, "Ketchup", () =>
            {
                x.Ketchup = true;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            BriarheartBurger x = new BriarheartBurger();

            Assert.PropertyChanged(x, "Cheese", () =>
            {
                x.Cheese = false;
            });
            Assert.PropertyChanged(x, "Cheese", () =>
            {
                x.Cheese = true;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            BriarheartBurger x = new BriarheartBurger();

            Assert.PropertyChanged(x, "Pickle", () =>
            {
                x.Pickle = false;
            });
            Assert.PropertyChanged(x, "Pickle", () =>
            {
                x.Pickle = true;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            BriarheartBurger x = new BriarheartBurger();

            Assert.PropertyChanged(x, "Mustard", () =>
            {
                x.Mustard = false;
            });
            Assert.PropertyChanged(x, "Mustard", () =>
            {
                x.Mustard = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            BriarheartBurger aj = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = false;
            Assert.False(bb.Bun);
            bb.Bun = true;
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = false;
            Assert.False(bb.Mustard);
            bb.Mustard = true;
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickle = false;
            Assert.False(bb.Pickle);
            bb.Pickle = true;
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = false;
            Assert.False(bb.Cheese);
            bb.Cheese = true;
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(bb.Calories, (uint)743);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickle = includePickle;
            bb.Cheese = includeCheese;
            if (!includeBun) Assert.Contains("Hold bun", bb.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", bb.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", bb.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", bb.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", bb.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese)
                Assert.Empty(bb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.ToString());
        }
    }
}