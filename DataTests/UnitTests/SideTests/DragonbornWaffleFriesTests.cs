/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dbw = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dbw.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dbw = new DragonbornWaffleFries();
            dbw.Size = Size.Large;
            Assert.Equal(Size.Large, dbw.Size);
            dbw.Size = Size.Medium;
            Assert.Equal(Size.Medium, dbw.Size);
            dbw.Size = Size.Small;
            Assert.Equal(Size.Small, dbw.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dbw = new DragonbornWaffleFries();
            Assert.Empty(dbw.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dbw = new DragonbornWaffleFries();
            dbw.Size = size;
            Assert.Equal(price, dbw.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dbw = new DragonbornWaffleFries();
            dbw.Size = size;
            Assert.Equal(calories, dbw.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dbw = new DragonbornWaffleFries();
            dbw.Size = size;
            Assert.Equal(name, dbw.ToString());
        }
    }
}