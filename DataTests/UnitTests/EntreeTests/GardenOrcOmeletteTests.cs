﻿/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */

using System.ComponentModel;
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entree;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(go);
        }
        [Fact]
        public void ShouldIncludeBroccoliByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Broccoli);
        }

        [Fact]
        public void ShouldIncludeMushroomsByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Mushrooms);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Tomato);
        }

        [Fact]
        public void ShouldIncludeCheddarByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = true;
            Assert.True(go.Broccoli);
            go.Broccoli = false;
            Assert.False(go.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = true;
            Assert.True(go.Broccoli);
            go.Broccoli = false;
            Assert.False(go.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Tomato = true;
            Assert.True(go.Tomato);
            go.Tomato = false;
            Assert.False(go.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Cheddar = true;
            Assert.True(go.Cheddar);
            go.Cheddar = false;
            Assert.False(go.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal(4.57, go.Price);

        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            uint cal = 404;
            Assert.Equal(cal, go.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette go = new GardenOrcOmelette();

            go.Broccoli = includeBroccoli;
            go.Mushrooms = includeMushrooms;
            go.Tomato = includeTomato;
            go.Cheddar = includeCheddar;

            if (!includeBroccoli) Assert.Contains("Hold broccoli", go.SpecialInstructions);
            else if (!includeMushrooms) Assert.Contains("Hold mushrooms", go.SpecialInstructions);
            else if (!includeTomato) Assert.Contains("Hold tomato", go.SpecialInstructions);
            else if (!includeCheddar) Assert.Contains("Hold cheddar", go.SpecialInstructions);
            else Assert.Empty(go.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            string name = "Garden Orc Omelette";
            Assert.Equal(name, go.ToString());
        }
        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var GOO = new GardenOrcOmelette();
            Assert.PropertyChanged(GOO, "Broccoli", () => { GOO.Broccoli = true; });
            Assert.PropertyChanged(GOO, "Broccoli", () => { GOO.Broccoli = false; });
        }
        [Fact]
        public void ChangingMushroomsNotifiesMushroomProperty()
        {
            var GOO = new GardenOrcOmelette();
            Assert.PropertyChanged(GOO, "Mushrooms", () => { GOO.Mushrooms = true; });
            Assert.PropertyChanged(GOO, "Mushrooms", () => { GOO.Mushrooms = false; });
        }
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var GOO = new GardenOrcOmelette();
            Assert.PropertyChanged(GOO, "Tomato", () => { GOO.Tomato = true; });
            Assert.PropertyChanged(GOO, "Tomato", () => { GOO.Tomato = false; });
        }
        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var GOO = new GardenOrcOmelette();
            Assert.PropertyChanged(GOO, "Cheddar", () => { GOO.Cheddar = true; });
            Assert.PropertyChanged(GOO, "Cheddar", () => { GOO.Cheddar = false; });
        }
        [Fact]
        public void ChangingBroccoliNotifiesSpecialInstructionsProperty()
        {
            var GOO = new GardenOrcOmelette();
            Assert.PropertyChanged(GOO, "SpecialInstructions", () => { GOO.Broccoli = true; });
            Assert.PropertyChanged(GOO, "SpecialInstructions", () => { GOO.Broccoli = false; });
        }
        [Fact]
        public void ChangingMushroomsNotifiesSpecialInstructionsProperty()
        {
            var GOO = new GardenOrcOmelette();
            Assert.PropertyChanged(GOO, "SpecialInstructions", () => { GOO.Mushrooms = true; });
            Assert.PropertyChanged(GOO, "SpecialInstructions", () => { GOO.Mushrooms = false; });
        }
        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            var GOO = new GardenOrcOmelette();
            Assert.PropertyChanged(GOO, "SpecialInstructions", () => { GOO.Tomato = true; });
            Assert.PropertyChanged(GOO, "SpecialInstructions", () => { GOO.Tomato = false; });
        }
        [Fact]
        public void InheritsInterface()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(goo);
        }
    }
}