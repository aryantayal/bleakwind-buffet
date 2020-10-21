/*
 * Author: Aryan Tayal
 * Class: WarriorWater.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using System.ComponentModel;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            var ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            var ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            var ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            var ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.0)]
        [InlineData(Size.Medium, 0.0)]
        [InlineData(Size.Large, 0.0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            var ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (!includeIce) Assert.Contains("Hold ice", ww.SpecialInstructions);
            else if (includeLemon) Assert.Contains("Add lemon", ww.SpecialInstructions);
            else Assert.Empty(ww.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }

        // 


        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "Ice", () => { WW.Ice = true; });
            Assert.PropertyChanged(WW, "Ice", () => { WW.Ice = false; });
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "Lemon", () => { WW.Lemon = true; });
            Assert.PropertyChanged(WW, "Lemon", () => { WW.Lemon = false; });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var WW = new AretinoAppleJuice();
            Assert.PropertyChanged(WW, "Calories", () => { WW.Size = Size.Small; });
            Assert.PropertyChanged(WW, "Calories", () => { WW.Size = Size.Medium; });
            Assert.PropertyChanged(WW, "Calories", () => { WW.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "Price", () => { WW.Size = Size.Small; });
            Assert.PropertyChanged(WW, "Price", () => { WW.Size = Size.Medium; });
            Assert.PropertyChanged(WW, "Price", () => { WW.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "SpecialInstructions", () => { WW.Ice = true; });
            Assert.PropertyChanged(WW, "SpecialInstructions", () => { WW.Ice = false; });
        }

        [Fact]
        public void ChangingSizeNotifiesSpecialInstructionsProperty()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "SpecialInstructions", () => { WW.Size = Size.Small; });
            Assert.PropertyChanged(WW, "SpecialInstructions", () => { WW.Size = Size.Medium; });
            Assert.PropertyChanged(WW, "SpecialInstructions", () => { WW.Size = Size.Large; });
        }

        [Fact]
        public void ChangingLemonNotifiesSpecialInstructionsProperty()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "SpecialInstructions", () => { WW.Lemon = true; });
            Assert.PropertyChanged(WW, "SpecialInstructions", () => { WW.Lemon = false; });
        }

        [Fact]
        public void InheritsInterface()
        {
            var ww = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ww);
        }
    }
}