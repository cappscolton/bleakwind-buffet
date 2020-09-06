/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal(ttb.Price, 6.44);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal(ttb.Calories, (uint)982);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Empty(ttb.SpecialInstructions);
        }


        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal(ttb.ToString(), "Thugs T-Bone");
        }
    }
}