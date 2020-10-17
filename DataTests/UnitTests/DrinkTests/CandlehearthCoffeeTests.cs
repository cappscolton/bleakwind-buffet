/*
 * Author: Colton Capps 
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            CandlehearthCoffee aj = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void ChangingPropertiesNotifiesSpecialInstructionsProperty()
        {
            var AJ = new CandlehearthCoffee();

            Assert.PropertyChanged(AJ, "SpecialInstructions", () =>
            {
                AJ.Ice = true;
            });

            Assert.PropertyChanged(AJ, "SpecialInstructions", () =>
            {
                AJ.Ice = false;
            });


            Assert.PropertyChanged(AJ, "SpecialInstructions", () =>
            {
                AJ.RoomForCream = true;
            });

            Assert.PropertyChanged(AJ, "SpecialInstructions", () =>
            {
                AJ.RoomForCream = false;
            });

        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var AJ = new CandlehearthCoffee();

            Assert.PropertyChanged(AJ, "Ice", () =>
            {
                AJ.Ice = true;
            });

            Assert.PropertyChanged(AJ, "Ice", () =>
            {
                AJ.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizePriceAndCalorieProperties()
        {
            var AJ = new CandlehearthCoffee();

            Assert.PropertyChanged(AJ, "Size", () =>
            {
                AJ.Size = Size.Medium;
            });

            Assert.PropertyChanged(AJ, "Price", () =>
            {
                AJ.Size = Size.Large;
            });

            Assert.PropertyChanged(AJ, "Calories", () =>
            {
                AJ.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingCreamNotifiesProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "RoomForCream", () =>
            {
                CC.RoomForCream = true;
            });

            Assert.PropertyChanged(CC, "RoomForCream", () =>
            {
                CC.RoomForCream = false;
            });

            Assert.PropertyChanged(CC, "SpecialInstructions", () =>
            {
                CC.RoomForCream = true;
            });
        }

        [Fact]
        public void ChangingDecafNotifiesProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "Decaf", () =>
            {
                CC.Decaf = true;
            });

            Assert.PropertyChanged(CC, "Decaf", () =>
            {
                CC.Decaf = false;
            });

            Assert.PropertyChanged(CC, "SpecialInstructions", () =>
            {
                CC.Decaf = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            CandlehearthCoffee aj = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee aj = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(aj);
        }
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = true;
            Assert.True(cc.Decaf);
            cc.Decaf = false;
            Assert.False(cc.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
            Assert.True(cc.RoomForCream);
            cc.RoomForCream = false;
            Assert.False(cc.RoomForCream);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(price, cc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(cal, cc.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = includeIce;
            cc.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", cc.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", cc.SpecialInstructions);
            if (!includeIce && !includeCream) Assert.Empty(cc.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = decaf;
            cc.Size = size;
            Assert.Equal(cc.ToString(), name);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cc.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = true;
            Assert.True(cc.Ice);
            cc.Ice = false;
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Size.Large;
            Assert.Equal(Size.Large, cc.Size);
            cc.Size = Size.Medium;
            Assert.Equal(Size.Medium, cc.Size);
            cc.Size = Size.Small;
            Assert.Equal(Size.Small, cc.Size);
        }


    }
}
