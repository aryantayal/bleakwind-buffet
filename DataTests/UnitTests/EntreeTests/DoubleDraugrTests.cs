/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */

using System.ComponentModel;
using BleakwindBuffet.Data.Entree;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var dd = new DoubleDraugr();
            dd.Bun = true;
            Assert.True(dd.Bun);
            dd.Bun = false;
            Assert.False(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var dd = new DoubleDraugr();
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var dd = new DoubleDraugr();
            dd.Mustard = true;
            Assert.True(dd.Mustard);
            dd.Mustard = false;
            Assert.False(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var dd = new DoubleDraugr();
            dd.Pickle = true;
            Assert.True(dd.Pickle);
            dd.Pickle = false;
            Assert.False(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var dd = new DoubleDraugr();
            dd.Cheese = true;
            Assert.True(dd.Cheese);
            dd.Cheese = false;
            Assert.False(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var dd = new DoubleDraugr();
            dd.Tomato = true;
            Assert.True(dd.Tomato);
            dd.Tomato = false;
            Assert.False(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var dd = new DoubleDraugr();
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var dd = new DoubleDraugr();
            dd.Mayo = true;
            Assert.True(dd.Mayo);
            dd.Mayo = false;
            Assert.False(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var dd = new DoubleDraugr();
            uint cal = 843;
            Assert.Equal(cal, dd.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
            bool includePickle, bool includeCheese, bool includeTomato,
            bool includeLettuce, bool includeMayo)
        {
            var dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;

            if (!includeBun) Assert.Contains("Hold bun", dd.SpecialInstructions);
            else if (!includeKetchup) Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            else if (!includeMustard) Assert.Contains("Hold mustard", dd.SpecialInstructions);
            else if (!includePickle) Assert.Contains("Hold pickle", dd.SpecialInstructions);
            else if (!includeCheese) Assert.Contains("Hold cheese", dd.SpecialInstructions);
            else if (!includeTomato) Assert.Contains("Hold tomato", dd.SpecialInstructions);
            else if (!includeLettuce) Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            else if (!includeMayo) Assert.Contains("Hold mayo", dd.SpecialInstructions);
            else Assert.Empty(dd.SpecialInstructions);
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Ketchup", () => { DD.Ketchup = true; });
            Assert.PropertyChanged(DD, "Ketchup", () => { DD.Ketchup = false; });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Mustard", () => { DD.Mustard = true; });
            Assert.PropertyChanged(DD, "Mustard", () => { DD.Mustard = false; });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Tomato", () => { DD.Tomato = true; });
            Assert.PropertyChanged(DD, "Tomato", () => { DD.Tomato = false; });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Mayo", () => { DD.Mayo = true; });
            Assert.PropertyChanged(DD, "Mayo", () => { DD.Mayo = false; });
        }

        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Ketchup = true; });
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Ketchup = false; });
        }

        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Bun = true; });
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Bun = false; });
        }

        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Mustard = true; });
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Mustard = false; });
        }

        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Pickle = true; });
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Pickle = false; });
        }

        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Tomato = true; });
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Tomato = false; });
        }

        [Fact]
        public void ChangingLettuceNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Lettuce = true; });
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Lettuce = false; });
        }

        [Fact]
        public void ChangingMayoNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Mayo = true; });
            Assert.PropertyChanged(DD, "SpecialInstructions", () => { DD.Mayo = false; });
        }

        [Fact]
        public void InheritsInterface()
        {
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dd);
        }
    }
}