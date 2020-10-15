/*
 * Author: Colton Capps
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using System.ComponentModel;

using BleakwindBuffet.Data.Entrees;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            GardenOrcOmelette aj = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void ChangingPropertiesNotifiesSpecialInstructionsProperty()
        {
            var x = new GardenOrcOmelette();

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Broccoli = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Cheddar = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Mushrooms = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Tomato = false;
            });

        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();

            Assert.PropertyChanged(x, "Broccoli", () =>
            {
                x.Broccoli = false;
            });
            Assert.PropertyChanged(x, "Broccoli", () =>
            {
                x.Broccoli = true;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();

            Assert.PropertyChanged(x, "Cheddar", () =>
            {
                x.Cheddar = false;
            });
            Assert.PropertyChanged(x, "Cheddar", () =>
            {
                x.Cheddar = true;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();

            Assert.PropertyChanged(x, "Mushrooms", () =>
            {
                x.Mushrooms = false;
            });
            Assert.PropertyChanged(x, "Mushrooms", () =>
            {
                x.Mushrooms = true;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            GardenOrcOmelette x = new GardenOrcOmelette();

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
            GardenOrcOmelette aj = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette bb = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(bb);
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = false;
            Assert.False(goo.Tomato);
            goo.Tomato = true;
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(4.57, goo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(goo.Calories, (uint)404);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            goo.Mushrooms = includeMushrooms;
            goo.Tomato = includeTomato;
            goo.Cheddar = includeCheddar;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", goo.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", goo.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", goo.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", goo.SpecialInstructions);
            if (includeBroccoli && includeBroccoli && includeTomato && includeCheddar)
                Assert.Empty(goo.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }
    }
}