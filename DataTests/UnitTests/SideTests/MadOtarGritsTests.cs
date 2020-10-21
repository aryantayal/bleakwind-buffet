/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */

using System.ComponentModel;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            var mo = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mo);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var mo = new MadOtarGrits();
            Assert.Equal(Size.Small, mo.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var mo = new MadOtarGrits();
            mo.Size = Size.Large;
            Assert.Equal(Size.Large, mo.Size);
            mo.Size = Size.Medium;
            Assert.Equal(Size.Medium, mo.Size);
            mo.Size = Size.Small;
            Assert.Equal(Size.Small, mo.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            var mo = new MadOtarGrits();
            Assert.Empty(mo.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(price, mo.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(calories, mo.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(name, mo.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var MOG = new MadOtarGrits();
            Assert.PropertyChanged(MOG, "Size", () => { MOG.Size = Size.Small; });
            Assert.PropertyChanged(MOG, "Size", () => { MOG.Size = Size.Medium; });
            Assert.PropertyChanged(MOG, "Size", () => { MOG.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var MOG = new MadOtarGrits();
            Assert.PropertyChanged(MOG, "Price", () => { MOG.Size = Size.Small; });
            Assert.PropertyChanged(MOG, "Price", () => { MOG.Size = Size.Medium; });
            Assert.PropertyChanged(MOG, "Price", () => { MOG.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var MOG = new MadOtarGrits();
            Assert.PropertyChanged(MOG, "Calories", () => { MOG.Size = Size.Small; });
            Assert.PropertyChanged(MOG, "Calories", () => { MOG.Size = Size.Medium; });
            Assert.PropertyChanged(MOG, "Calories", () => { MOG.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeNotifiesSpecialInstructionsProperty()
        {
            var MOG = new MadOtarGrits();
            Assert.PropertyChanged(MOG, "SpecialInstructions", () => { MOG.Size = Size.Small; });
            Assert.PropertyChanged(MOG, "SpecialInstructions", () => { MOG.Size = Size.Medium; });
            Assert.PropertyChanged(MOG, "SpecialInstructions", () => { MOG.Size = Size.Large; });
        }

        [Fact]
        public void InheritsInterface()
        {
            var mog = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mog);
        }
    }
}