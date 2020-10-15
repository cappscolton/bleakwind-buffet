/*
 * Author: Colton Capps 
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            PhillyPoacher aj = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void ChangingPropertiesNotifiesSpecialInstructionsProperty()
        {
            var x = new PhillyPoacher();

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Sirloin = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Onion = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Roll = false;
            });
        }

        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            PhillyPoacher x = new PhillyPoacher();

            Assert.PropertyChanged(x, "Roll", () =>
            {
                x.Roll = false;
            });
            Assert.PropertyChanged(x, "Roll", () =>
            {
                x.Roll = true;
            });
        }

        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            PhillyPoacher x = new PhillyPoacher();

            Assert.PropertyChanged(x, "Onion", () =>
            {
                x.Onion = false;
            });
            Assert.PropertyChanged(x, "Onion", () =>
            {
                x.Onion = true;
            });
        }

        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            PhillyPoacher x = new PhillyPoacher();

            Assert.PropertyChanged(x, "Sirloin", () =>
            {
                x.Sirloin = false;
            });
            Assert.PropertyChanged(x, "Sirloin", () =>
            {
                x.Sirloin = true;
            });
        }


        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            PhillyPoacher aj = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher bb = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(bb);
        }
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = false;
            Assert.False(pp.Onion);
            pp.Onion = true;
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = false;
            Assert.False(pp.Roll);
            pp.Roll = true;
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(pp.Calories, (uint)784);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;
            if (!includeSirloin) Assert.Contains("Hold sirloin", pp.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onion", pp.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", pp.SpecialInstructions);
            if (includeSirloin && includeOnion && includeRoll)
                Assert.Empty(pp.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }
    }
}