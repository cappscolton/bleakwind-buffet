using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void AddingDrinkShouldTriggerPropertyChanged()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Drink = new AretinoAppleJuice();
            });
            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = new AretinoAppleJuice();
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Drink = new AretinoAppleJuice();
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Drink = new AretinoAppleJuice();
            });
        }

        [Fact]
        public void AddingSideShouldTriggerPropertyChanged()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Side = new VokunSalad();
            });
            Assert.PropertyChanged(c, "Side", () =>
            {
                c.Side = new VokunSalad();
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side = new VokunSalad();
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Side = new VokunSalad();
            });
        }

        [Fact]
        public void AddingEntreeShouldTriggerPropertyChanged()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Entree = new BriarheartBurger();
            });
            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = new BriarheartBurger();
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Entree = new BriarheartBurger();
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Entree = new BriarheartBurger();
            });
        }

        [Fact]
        public void ChangingItemSizeTriggersPricePropertyChangedEventForCombo()
        {
            Combo c = new Combo();
            c.Side = new VokunSalad();
            c.Drink = new AretinoAppleJuice();
            Assert.PropertyChanged(c, "Price", () =>
            {
                (c.Side as VokunSalad).Size = Size.Large;
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                (c.Drink as AretinoAppleJuice).Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingItemSizeTriggersCaloriesPropertyChangedEventForCombo()
        {
            Combo c = new Combo();
            c.Side = new VokunSalad();
            c.Drink = new AretinoAppleJuice();
            Assert.PropertyChanged(c, "Calories", () =>
            {
                (c.Side as VokunSalad).Size = Size.Large;
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                (c.Drink as AretinoAppleJuice).Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingItemSpecialInstructionsTriggersSpecialInstructionsPropertyChangedEventForCombo()
        {
            Combo c = new Combo();
            c.Entree = new BriarheartBurger();
            c.Side = new VokunSalad();
            c.Drink = new AretinoAppleJuice();
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                BriarheartBurger b = c.Entree as BriarheartBurger;
                b.Bun = false;
            });
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                AretinoAppleJuice a = c.Drink as AretinoAppleJuice;
                a.Ice = true;
            });
        }
    }
}
