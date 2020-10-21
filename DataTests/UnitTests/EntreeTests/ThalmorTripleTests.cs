/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */

using System.ComponentModel;
using BleakwindBuffet.Data.Entree;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            var tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var tt = new ThalmorTriple();
            tt.Bun = true;
            Assert.True(tt.Bun);
            tt.Bun = false;
            Assert.False(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var tt = new ThalmorTriple();
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var tt = new ThalmorTriple();
            tt.Mustard = true;
            Assert.True(tt.Mustard);
            tt.Mustard = false;
            Assert.False(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var tt = new ThalmorTriple();
            tt.Pickle = true;
            Assert.True(tt.Pickle);
            tt.Pickle = false;
            Assert.False(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var tt = new ThalmorTriple();
            tt.Cheese = true;
            Assert.True(tt.Cheese);
            tt.Cheese = false;
            Assert.False(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var tt = new ThalmorTriple();
            tt.Tomato = true;
            Assert.True(tt.Tomato);
            tt.Tomato = false;
            Assert.False(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var tt = new ThalmorTriple();
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var tt = new ThalmorTriple();
            tt.Mayo = true;
            Assert.True(tt.Mayo);
            tt.Mayo = false;
            Assert.False(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            var tt = new ThalmorTriple();
            tt.Bacon = true;
            Assert.True(tt.Bacon);
            tt.Bacon = false;
            Assert.False(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var tt = new ThalmorTriple();
            tt.Egg = true;
            Assert.True(tt.Egg);
            tt.Egg = false;
            Assert.False(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var tt = new ThalmorTriple();
            uint cal = 943;
            Assert.Equal(cal, tt.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
            bool includePickle, bool includeCheese, bool includeTomato,
            bool includeLettuce, bool includeMayo,
            bool includeBacon, bool includeEgg)
        {
            var tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;

            if (!includeBun) Assert.Contains("Hold bun", tt.SpecialInstructions);
            else if (!includeKetchup) Assert.Contains("Hold ketchup", tt.SpecialInstructions);
            else if (!includeMustard) Assert.Contains("Hold mustard", tt.SpecialInstructions);
            else if (!includePickle) Assert.Contains("Hold pickle", tt.SpecialInstructions);
            else if (!includeCheese) Assert.Contains("Hold cheese", tt.SpecialInstructions);
            else if (!includeTomato) Assert.Contains("Hold tomato", tt.SpecialInstructions);
            else if (!includeBacon) Assert.Contains("Hold bacon", tt.SpecialInstructions);
            else if (!includeEgg) Assert.Contains("Hold egg", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var tt = new ThalmorTriple();
            var name = "Thalmor Triple";
            Assert.Equal(name, tt.ToString());
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Ketchup", () => { TT.Ketchup = true; });
            Assert.PropertyChanged(TT, "Ketchup", () => { TT.Ketchup = false; });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Mustard", () => { TT.Mustard = true; });
            Assert.PropertyChanged(TT, "Mustard", () => { TT.Mustard = false; });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Tomato", () => { TT.Tomato = true; });
            Assert.PropertyChanged(TT, "Tomato", () => { TT.Tomato = false; });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Mayo", () => { TT.Mayo = true; });
            Assert.PropertyChanged(TT, "Mayo", () => { TT.Mayo = false; });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Egg", () => { TT.Egg = true; });
            Assert.PropertyChanged(TT, "Egg", () => { TT.Egg = false; });
        }

        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Bacon", () => { TT.Bacon = true; });
            Assert.PropertyChanged(TT, "Bacon", () => { TT.Bacon = false; });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Lettuce", () => { TT.Lettuce = true; });
            Assert.PropertyChanged(TT, "Lettuce", () => { TT.Lettuce = false; });
        }

        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Ketchup = true; });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Ketchup = false; });
        }

        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Mustard = true; });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Mustard = false; });
        }

        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Tomato = true; });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Tomato = false; });
        }

        [Fact]
        public void ChangingMayoNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Mayo = true; });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Mayo = false; });
        }

        [Fact]
        public void ChangingEggNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Egg = true; });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Egg = false; });
        }

        [Fact]
        public void ChangingBaconNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Bacon = true; });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Bacon = false; });
        }

        [Fact]
        public void ChangingLettuceNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Lettuce = true; });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => { TT.Lettuce = false; });
        }

        [Fact]
        public void InheritsInterface()
        {
            var tt = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }
    }
}