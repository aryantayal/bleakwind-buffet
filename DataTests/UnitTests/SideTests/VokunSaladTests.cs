﻿/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */

using System.ComponentModel;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            var vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var vs = new VokunSalad();
            Assert.Equal(Size.Small, vs.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var vs = new VokunSalad();
            vs.Size = Size.Large;
            Assert.Equal(Size.Large, vs.Size);
            vs.Size = Size.Medium;
            Assert.Equal(Size.Medium, vs.Size);
            vs.Size = Size.Small;
            Assert.Equal(Size.Small, vs.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var vs = new VokunSalad();
            Assert.Empty(vs.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var dbw = new VokunSalad();
            dbw.Size = size;
            Assert.Equal(price, dbw.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(calories, vs.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(name, vs.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var VS = new VokunSalad();
            Assert.PropertyChanged(VS, "Size", () => { VS.Size = Size.Small; });
            Assert.PropertyChanged(VS, "Size", () => { VS.Size = Size.Medium; });
            Assert.PropertyChanged(VS, "Size", () => { VS.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var VS = new VokunSalad();
            Assert.PropertyChanged(VS, "Price", () => { VS.Size = Size.Small; });
            Assert.PropertyChanged(VS, "Price", () => { VS.Size = Size.Medium; });
            Assert.PropertyChanged(VS, "Price", () => { VS.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var VS = new VokunSalad();
            Assert.PropertyChanged(VS, "Calories", () => { VS.Size = Size.Small; });
            Assert.PropertyChanged(VS, "Calories", () => { VS.Size = Size.Medium; });
            Assert.PropertyChanged(VS, "Calories", () => { VS.Size = Size.Large; });
        }

        [Fact]
        public void InheritsInterface()
        {
            var vs = new VokunSalad();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(vs);
        }
    }
}