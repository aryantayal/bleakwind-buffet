/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger bh = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bh);
        }
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bh = new BriarheartBurger();
            Assert.True(bh.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bh = new BriarheartBurger();
            Assert.True(bh.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bh = new BriarheartBurger();
            Assert.True(bh.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bh = new BriarheartBurger();
            Assert.True(bh.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bh = new BriarheartBurger();
            Assert.True(bh.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bh = new BriarheartBurger();
            bh.Bun = true;
            Assert.True(bh.Bun);
            bh.Bun = false;
            Assert.False(bh.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bh = new BriarheartBurger();
            bh.Ketchup = true;
            Assert.True(bh.Ketchup);
            bh.Ketchup = false;
            Assert.False(bh.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bh = new BriarheartBurger();
            bh.Mustard = true;
            Assert.True(bh.Mustard);
            bh.Mustard = false;
            Assert.False(bh.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bh = new BriarheartBurger();
            bh.Pickle = true;
            Assert.True(bh.Pickle);
            bh.Pickle = false;
            Assert.False(bh.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bh = new BriarheartBurger();
            bh.Cheese = true;
            Assert.True(bh.Cheese);
            bh.Cheese = false;
            Assert.False(bh.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bh = new BriarheartBurger();
            Assert.Equal(6.32, bh.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bh = new BriarheartBurger();
            uint cal = 732;
            Assert.Equal(cal, bh.Calories);

        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bh = new BriarheartBurger();
            bh.Bun = includeBun;
            bh.Ketchup = includeKetchup;
            bh.Mustard = includeMustard;
            bh.Pickle = includePickle;
            bh.Cheese = includeCheese;

            if (!includeBun) Assert.Contains("Hold bun", bh.SpecialInstructions);
            else if (!includeKetchup) Assert.Contains("Hold ketchup", bh.SpecialInstructions);
            else if (!includeMustard) Assert.Contains("Hold mustard", bh.SpecialInstructions);
            else if (!includePickle) Assert.Contains("Hold pickle", bh.SpecialInstructions);
            else if (!includeCheese) Assert.Contains("Hold cheese", bh.SpecialInstructions);
            else Assert.Empty(bh.SpecialInstructions);


        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bh = new BriarheartBurger();
            string name = "Briarheart Burger";
            Assert.Equal(name, bh.ToString());
        }
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, "Ketchup", () => { BB.Ketchup = true; });
            Assert.PropertyChanged(BB, "Ketchup", () => { BB.Ketchup = false; });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, "Mustard", () => { BB.Mustard = true; });
            Assert.PropertyChanged(BB, "Mustard", () => { BB.Mustard = false; });
        }
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, "Pickle", () => { BB.Pickle = true; });
            Assert.PropertyChanged(BB, "Pickle", () => { BB.Pickle = false; });
        }
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, "Cheese", () => { BB.Cheese = true; });
            Assert.PropertyChanged(BB, "Cheese", () => { BB.Cheese = false; });
        }
        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            var BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, "SpecialInstructions", () => { BB.Ketchup = true; });
            Assert.PropertyChanged(BB, "SpecialInstructions", () => { BB.Ketchup = false; });
        }
        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            var BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, "SpecialInstructions", () => { BB.Mustard = true; });
            Assert.PropertyChanged(BB, "SpecialInstructions", () => { BB.Mustard = false; });
        }
        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            var BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, "SpecialInstructions", () => { BB.Pickle = true; });
            Assert.PropertyChanged(BB, "SpecialInstructions", () => { BB.Pickle = false; });
        }
        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            var BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, "SpecialInstructions", () => { BB.Cheese = true; });
            Assert.PropertyChanged(BB, "SpecialInstructions", () => { BB.Cheese = false; });
        }
        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            var BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, "SpecialInstructions", () => { BB.Bun = true; });
            Assert.PropertyChanged(BB, "SpecialInstructions", () => { BB.Bun = false; });
        }
    }
}