﻿/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */

using System.ComponentModel;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            var fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var fm = new FriedMiraak();
            Assert.Equal(Size.Small, fm.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var fm = new FriedMiraak();
            fm.Size = Size.Large;
            Assert.Equal(Size.Large, fm.Size);
            fm.Size = Size.Medium;
            Assert.Equal(Size.Medium, fm.Size);
            fm.Size = Size.Small;
            Assert.Equal(Size.Small, fm.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var fm = new FriedMiraak();
            Assert.Empty(fm.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(price, fm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(calories, fm.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(name, fm.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var FM = new FriedMiraak();
            Assert.PropertyChanged(FM, "Size", () => { FM.Size = Size.Small; });
            Assert.PropertyChanged(FM, "Size", () => { FM.Size = Size.Medium; });
            Assert.PropertyChanged(FM, "Size", () => { FM.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var FM = new FriedMiraak();
            Assert.PropertyChanged(FM, "Price", () => { FM.Size = Size.Small; });
            Assert.PropertyChanged(FM, "Price", () => { FM.Size = Size.Medium; });
            Assert.PropertyChanged(FM, "Price", () => { FM.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var FM = new FriedMiraak();
            Assert.PropertyChanged(FM, "Calories", () => { FM.Size = Size.Small; });
            Assert.PropertyChanged(FM, "Calories", () => { FM.Size = Size.Medium; });
            Assert.PropertyChanged(FM, "Calories", () => { FM.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeNotifiesSpecialInstructionsProperty()
        {
            var FM = new FriedMiraak();
            Assert.PropertyChanged(FM, "SpecialInstructions", () => { FM.Size = Size.Small; });
            Assert.PropertyChanged(FM, "SpecialInstructions", () => { FM.Size = Size.Medium; });
            Assert.PropertyChanged(FM, "SpecialInstructions", () => { FM.Size = Size.Large; });
        }

        [Fact]
        public void InheritsInterface()
        {
            var fm = new FriedMiraak();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fm);
        }
    }
}