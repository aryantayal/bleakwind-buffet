/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */

using System.ComponentModel;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            var ch = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(ch);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var ch = new CandlehearthCoffee();
            Assert.False(ch.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            var ch = new CandlehearthCoffee();
            Assert.False(ch.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            var ch = new CandlehearthCoffee();
            Assert.False(ch.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var ch = new CandlehearthCoffee();
            Assert.Equal(Size.Small, ch.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var ch = new CandlehearthCoffee();
            ch.Ice = true;
            Assert.True(ch.Ice);
            ch.Ice = false;
            Assert.False(ch.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            var ch = new CandlehearthCoffee();
            ch.Decaf = true;
            Assert.True(ch.Decaf);
            ch.Decaf = false;
            Assert.False(ch.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            var ch = new CandlehearthCoffee();
            ch.RoomForCream = true;
            Assert.True(ch.RoomForCream);
            ch.RoomForCream = false;
            Assert.False(ch.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var ch = new CandlehearthCoffee();
            ch.Size = Size.Large;
            Assert.Equal(Size.Large, ch.Size);
            ch.Size = Size.Medium;
            Assert.Equal(Size.Medium, ch.Size);
            ch.Size = Size.Small;
            Assert.Equal(Size.Small, ch.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var ch = new CandlehearthCoffee();
            ch.Size = size;
            Assert.Equal(price, ch.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var ch = new CandlehearthCoffee();
            ch.Size = size;
            Assert.Equal(cal, ch.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            var ch = new CandlehearthCoffee();
            ch.Ice = includeIce;
            ch.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", ch.SpecialInstructions);
            else if (includeCream) Assert.Contains("Add Room for cream", ch.SpecialInstructions);
            else Assert.Empty(ch.SpecialInstructions);
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
            var ch = new CandlehearthCoffee();
            ch.Size = size;
            ch.Decaf = decaf;
            Assert.Equal(name, ch.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var CC = new CandlehearthCoffee();
            Assert.PropertyChanged(CC, "Ice", () => { CC.Ice = true; });
            Assert.PropertyChanged(CC, "Ice", () => { CC.Ice = false; });
        }

        [Fact]
        public void ChangingCreamNotifiesCreamProperty()
        {
            var CC = new CandlehearthCoffee();
            Assert.PropertyChanged(CC, "Cream", () => { CC.RoomForCream = true; });
            Assert.PropertyChanged(CC, "Cream", () => { CC.RoomForCream = false; });
        }

        [Fact]
        public void ChangingDecafNotifiesDecafProperty()
        {
            var CC = new CandlehearthCoffee();
            Assert.PropertyChanged(CC, "Decaf", () => { CC.Decaf = true; });
            Assert.PropertyChanged(CC, "Decaf", () => { CC.Decaf = false; });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var CC = new CandlehearthCoffee();
            Assert.PropertyChanged(CC, "Size", () => { CC.Size = Size.Small; });
            Assert.PropertyChanged(CC, "Size", () => { CC.Size = Size.Medium; });
            Assert.PropertyChanged(CC, "Size", () => { CC.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var CC = new CandlehearthCoffee();
            Assert.PropertyChanged(CC, "Price", () => { CC.Size = Size.Small; });
            Assert.PropertyChanged(CC, "Price", () => { CC.Size = Size.Medium; });
            Assert.PropertyChanged(CC, "Price", () => { CC.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var CC = new CandlehearthCoffee();
            Assert.PropertyChanged(CC, "Calories", () => { CC.Size = Size.Small; });
            Assert.PropertyChanged(CC, "Calories", () => { CC.Size = Size.Medium; });
            Assert.PropertyChanged(CC, "Calories", () => { CC.Size = Size.Large; });
        }

        [Fact]
        public void InheritsInterface()
        {
            var chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chc);
        }
    }
}