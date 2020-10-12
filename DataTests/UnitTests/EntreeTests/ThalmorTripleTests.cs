/*
 * Author: Colton Capps 
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            ThalmorTriple aj = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void ChangingPropertiesNotifiesSpecialInstructionsProperty()
        {
            var x = new ThalmorTriple();

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

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Bacon = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Egg = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            ThalmorTriple x = new ThalmorTriple();

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
            ThalmorTriple x = new ThalmorTriple();

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
            ThalmorTriple x = new ThalmorTriple();

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
            ThalmorTriple x = new ThalmorTriple();

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
            ThalmorTriple x = new ThalmorTriple();

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
            ThalmorTriple x = new ThalmorTriple();

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
            ThalmorTriple x = new ThalmorTriple();

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
            ThalmorTriple x = new ThalmorTriple();

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
        public void ChangingBaconNotifiesBaconProperty()
        {
            ThalmorTriple x = new ThalmorTriple();

            Assert.PropertyChanged(x, "Bacon", () =>
            {
                x.Bacon = false;
            });
            Assert.PropertyChanged(x, "Bacon", () =>
            {
                x.Bacon = true;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            ThalmorTriple x = new ThalmorTriple();

            Assert.PropertyChanged(x, "Egg", () =>
            {
                x.Egg = false;
            });
            Assert.PropertyChanged(x, "Egg", () =>
            {
                x.Egg = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThalmorTriple aj = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple bb = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(bb);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle );
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();

            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();

            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();

            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();

            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();

            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();

            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();

            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();

            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();

            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();

            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(tt.Price, 8.32);

        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(tt.Calories, (uint)943);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;

            if (!includeBun) Assert.Contains("Hold bun", tt.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", tt.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", tt.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", tt.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", tt.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", tt.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", tt.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", tt.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", tt.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", tt.SpecialInstructions);


            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce && includeMayo && includeBacon && includeEgg)
                Assert.Empty(tt.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple pp = new ThalmorTriple();
            Assert.Equal(pp.ToString(), "Thalmor Triple");
        }
    }
}