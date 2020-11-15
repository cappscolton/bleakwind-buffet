/*
 * Author: Colton Capps 
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            SmokehouseSkeleton x = new SmokehouseSkeleton();
            Assert.Equal("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.", x.Description);
        }
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            SmokehouseSkeleton aj = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void ChangingPropertiesNotifiesSpecialInstructionsProperty()
        {
            var x = new SmokehouseSkeleton();

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.HashBrowns = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Pancake = false;
            });

            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.Egg = false;
            });
            Assert.PropertyChanged(x, "SpecialInstructions", () =>
            {
                x.SausageLink = false;
            });
        }


        [Fact]
        public void ChangingHashBrownsNotifiesHashBrownsProperty()
        {
            SmokehouseSkeleton x = new SmokehouseSkeleton();

            Assert.PropertyChanged(x, "HashBrowns", () =>
            {
                x.HashBrowns = false;
            });
            Assert.PropertyChanged(x, "HashBrowns", () =>
            {
                x.HashBrowns = true;
            });
        }

        [Fact]
        public void ChangingSausageNotifiesSausageProperty()
        {
            SmokehouseSkeleton x = new SmokehouseSkeleton();

            Assert.PropertyChanged(x, "SausageLink", () =>
            {
                x.SausageLink = false;
            });
            Assert.PropertyChanged(x, "SausageLink", () =>
            {
                x.SausageLink = true;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            SmokehouseSkeleton x = new SmokehouseSkeleton();

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
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            SmokehouseSkeleton x = new SmokehouseSkeleton();

            Assert.PropertyChanged(x, "Pancake", () =>
            {
                x.Pancake = false;
            });
            Assert.PropertyChanged(x, "Pancake", () =>
            {
                x.Pancake = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SmokehouseSkeleton aj = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton bb = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(bb);
        }
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = false;
            Assert.False(ss.Egg);
            ss.Egg = true;
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = false;
            Assert.False(ss.Pancake);
            ss.Pancake = true;
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(ss.Calories, (uint)602);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;
            if (!includeSausage) Assert.Contains("Hold sausage", ss.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", ss.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            if (includeSausage && includeEgg && includeHashbrowns && includeSausage)
                Assert.Empty(ss.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton pp = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", pp.ToString());
        }
    }
}