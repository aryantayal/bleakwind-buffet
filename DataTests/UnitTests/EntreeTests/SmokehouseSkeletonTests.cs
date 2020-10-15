/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */

using System.ComponentModel;
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entree;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton(); 
            Assert.IsAssignableFrom<Entree>(ss);
        }
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = true;
            Assert.True(ss.Egg);
            ss.Egg = false;
            Assert.False(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = true;
            Assert.True(ss.Pancake);
            ss.Pancake = false;
            Assert.False(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            uint cal = 602;
            Assert.Equal(cal, ss.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;

            if (!includeSausage) Assert.Contains("Hold sausage", ss.SpecialInstructions);
            else if (!includeEgg) Assert.Contains("Hold eggs", ss.SpecialInstructions);
            else if (!includeHashbrowns) Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            else if (!includePancake) Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            string name = "Smokehouse Skeleton";
            Assert.Equal(name, ss.ToString());
        }
        [Fact]
        public void ChangingSausageNotifiesSausageProperty()
        {
            var SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, "SausageLink", () => { SS.SausageLink = true; });
            Assert.PropertyChanged(SS, "SausageLink", () => { SS.SausageLink = false; });
        }
        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, "Egg", () => { SS.Egg = true; });
            Assert.PropertyChanged(SS, "Egg", () => { SS.Egg = false; });
        }
        [Fact]
        public void ChangingHashbrownNotifiesHashbrownProperty()
        {
            var SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, "Hashbrowns", () => { SS.HashBrowns = true; });
            Assert.PropertyChanged(SS, "Hashbrowns", () => { SS.HashBrowns = false; });
        }
        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            var SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, "Pancake", () => { SS.Pancake = true; });
            Assert.PropertyChanged(SS, "Pancake", () => { SS.Pancake = false; });
        }
        [Fact]
        public void ChangingRollNotifiesSpecialInstructionsProperty()
        {
            var SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.SausageLink = true; });
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.SausageLink = false; });
        }
        [Fact]
        public void ChangingEggNotifiesSpecialInstructionsProperty()
        {
            var SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Egg = true; });
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Egg = false; });
        }
        [Fact]
        public void ChangingHashBrownsNotifiesSpecialInstructionsProperty()
        {
            var SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.HashBrowns = true; });
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.HashBrowns = false; });
        }
        [Fact]
        public void ChangingPancakeNotifiesSpecialInstructionsProperty()
        {
            var SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Pancake = true; });
            Assert.PropertyChanged(SS, "SpecialInstructions", () => { SS.Pancake = false; });
        }
        [Fact]
        public void InheritsInterface()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }
    }
}