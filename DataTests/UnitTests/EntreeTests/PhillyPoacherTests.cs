/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */

using System.ComponentModel;
using BleakwindBuffet.Data.Entree;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            var pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            var pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            var pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            var pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            var pp = new PhillyPoacher();
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            var pp = new PhillyPoacher();
            pp.Onion = true;
            Assert.True(pp.Onion);
            pp.Onion = false;
            Assert.False(pp.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            var pp = new PhillyPoacher();
            pp.Roll = true;
            Assert.True(pp.Roll);
            pp.Roll = false;
            Assert.False(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var pp = new PhillyPoacher();
            uint cal = 784;
            Assert.Equal(cal, pp.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
            bool includeRoll)
        {
            var pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;

            if (!includeSirloin) Assert.Contains("Hold sirloin", pp.SpecialInstructions);
            else if (!includeOnion) Assert.Contains("Hold onion", pp.SpecialInstructions);
            else if (!includeRoll) Assert.Contains("Hold roll", pp.SpecialInstructions);
            else Assert.Empty(pp.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var pp = new PhillyPoacher();
            var name = "Philly Poacher";
            Assert.Equal(name, pp.ToString());
        }

        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            var PP = new PhillyPoacher();
            Assert.PropertyChanged(PP, "Sirloin", () => { PP.Sirloin = true; });
            Assert.PropertyChanged(PP, "Sirloin", () => { PP.Sirloin = false; });
        }

        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            var PP = new PhillyPoacher();
            Assert.PropertyChanged(PP, "Onion", () => { PP.Onion = true; });
            Assert.PropertyChanged(PP, "Onion", () => { PP.Onion = false; });
        }

        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            var PP = new PhillyPoacher();
            Assert.PropertyChanged(PP, "Roll", () => { PP.Roll = true; });
            Assert.PropertyChanged(PP, "Roll", () => { PP.Roll = false; });
        }

        [Fact]
        public void ChangingSirloinNotifiesSpecialInstructionsProperty()
        {
            var PP = new PhillyPoacher();
            Assert.PropertyChanged(PP, "SpecialInstructions", () => { PP.Sirloin = true; });
            Assert.PropertyChanged(PP, "SpecialInstructions", () => { PP.Sirloin = false; });
        }

        [Fact]
        public void ChangingOnionNotifiesSpecialInstructionsProperty()
        {
            var PP = new PhillyPoacher();
            Assert.PropertyChanged(PP, "SpecialInstructions", () => { PP.Onion = true; });
            Assert.PropertyChanged(PP, "SpecialInstructions", () => { PP.Onion = false; });
        }

        [Fact]
        public void ChangingRollNotifiesSpecialInstructionsProperty()
        {
            var PP = new PhillyPoacher();
            Assert.PropertyChanged(PP, "SpecialInstructions", () => { PP.Roll = true; });
            Assert.PropertyChanged(PP, "SpecialInstructions", () => { PP.Roll = false; });
        }

        [Fact]
        public void InheritsInterface()
        {
            var pp = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pp);
        }
    }
}