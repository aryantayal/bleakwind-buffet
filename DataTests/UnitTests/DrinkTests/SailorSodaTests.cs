﻿/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */

using System.ComponentModel;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            var ss = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(ss);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            var ss = new SailorSoda();
            Assert.True(ss.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var ss = new SailorSoda();
            Assert.Equal(Size.Small, ss.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            var ss = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var ss = new SailorSoda();
            ss.Ice = true;
            Assert.True(ss.Ice);
            ss.Ice = false;
            Assert.False(ss.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var ss = new SailorSoda();
            ss.Size = Size.Large;
            Assert.Equal(Size.Large, ss.Size);
            ss.Size = Size.Medium;
            Assert.Equal(Size.Medium, ss.Size);
            ss.Size = Size.Small;
            Assert.Equal(Size.Small, ss.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            var ss = new SailorSoda();
            ss.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, ss.Flavor);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
            ss.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, ss.Flavor);
            ss.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, ss.Flavor);
            ss.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, ss.Flavor);
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(price, ss.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var ss = new SailorSoda();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var ss = new SailorSoda();
            ss.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);
        }

        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            var ss = new SailorSoda();
            ss.Size = size;
            ss.Flavor = flavor;
            Assert.Equal(name, ss.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "Ice", () => { SS.Ice = true; });
            Assert.PropertyChanged(SS, "Ice", () => { SS.Ice = false; });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "Calories", () => { SS.Size = Size.Small; });
            Assert.PropertyChanged(SS, "Calories", () => { SS.Size = Size.Medium; });
            Assert.PropertyChanged(SS, "Calories", () => { SS.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "Price", () => { SS.Size = Size.Small; });
            Assert.PropertyChanged(SS, "Price", () => { SS.Size = Size.Medium; });
            Assert.PropertyChanged(SS, "Price", () => { SS.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialProperty()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Ice = true; });
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Ice = false; });
        }

        [Fact]
        public void ChangingSizeNotifiesSpecialInstructionsProperty()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Size = Size.Small; });
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Size = Size.Medium; });
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Size = Size.Large; });
        }

        [Fact]
        public void ChangingFlavorToBlackBerryNotifiesSpecialInstructionsProperty()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Flavor = SodaFlavor.Blackberry; });
        }

        [Fact]
        public void ChangingFlavorToCherryNotifiesSpecialInstructionsProperty()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Flavor = SodaFlavor.Cherry; });
        }

        [Fact]
        public void ChangingFlavorToGrapefruitNotifiesSpecialInstructionsProperty()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Flavor = SodaFlavor.Grapefruit; });
        }

        [Fact]
        public void ChangingFlavorToLemonNotifiesSpecialInstructionsProperty()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Flavor = SodaFlavor.Lemon; });
        }

        [Fact]
        public void ChangingFlavorToPeachNotifiesSpecialInstructionsProperty()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Flavor = SodaFlavor.Peach; });
        }

        [Fact]
        public void ChangingFlavorToWattermelonNotifiesSpecialInstructionsProperty()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Flavor = SodaFlavor.Watermelon; });
        }

        [Fact]
        public void InheritsInterface()
        {
            var ss = new SailorSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }
    }
}