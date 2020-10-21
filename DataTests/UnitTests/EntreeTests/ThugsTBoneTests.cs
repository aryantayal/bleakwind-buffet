/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */

using System.ComponentModel;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entree;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            var tt = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var tt = new ThugsTBone();
            Assert.Equal(6.44, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var tt = new ThugsTBone();
            uint cal = 982;
            Assert.Equal(cal, tt.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var tt = new ThugsTBone();
            Assert.Empty(tt.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var tt = new ThugsTBone();
            var name = "Thugs T-Bone";
            Assert.Equal(name, tt.ToString());
        }

        [Fact]
        public void InheritsInterface()
        {
            var tt = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }
    }
}