/*
 * Author: Colton Capps
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using System.ComponentModel;

using BleakwindBuffet.Data.Entrees;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{

    
    public class DoubleDraugrTests
    {

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            DoubleDraugr aj = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void ChangingPropertiesNotifiesSpecialInstructionsProperty()
        {
            var x = new DoubleDraugr();

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

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Mayo = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Lettuce = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Tomato = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            DoubleDraugr x = new DoubleDraugr();

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
            DoubleDraugr x = new DoubleDraugr();

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
            DoubleDraugr x = new DoubleDraugr();

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
            DoubleDraugr x = new DoubleDraugr();

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
            DoubleDraugr x = new DoubleDraugr();

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
        public void ChangingMayoNotifiesMayoProperty()
        {
            DoubleDraugr x = new DoubleDraugr();

            Assert.PropertyChanged(x, "Mayo", () =>
            {
                x.Mayo = false;
            });
            Assert.PropertyChanged(x, "Mayo", () =>
            {
                x.Mayo = true;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            DoubleDraugr x = new DoubleDraugr();

            Assert.PropertyChanged(x, "Lettuce", () =>
            {
                x.Lettuce = false;
            });
            Assert.PropertyChanged(x, "Lettuce", () =>
            {
                x.Lettuce = true;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            DoubleDraugr x = new DoubleDraugr();

            Assert.PropertyChanged(x, "Tomato", () =>
            {
                x.Tomato = false;
            });
            Assert.PropertyChanged(x, "Tomato", () =>
            {
                x.Tomato = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DoubleDraugr aj = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr bb = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(bb);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
        DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(dd.Price, 7.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(dd.Calories, (uint)843);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(dd.ToString(), "Double Draugr");
        }
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;
            if (!includeBun) Assert.Contains("Hold bun", dd.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", dd.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", dd.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", dd.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", dd.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", dd.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce && includeMayo)
                Assert.Empty(dd.SpecialInstructions);
        }
    }
}