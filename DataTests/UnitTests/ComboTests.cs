/*
 * Author: Aryan Tayal
 * Class: OrderTests.cs
 * Purpose: Test the OrderTests.cs class in the Data library
 */

using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {

        [Fact]
        public void IfEntreeComboPriceIsCorrect()
        {
            Combo c = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Entree = b;
            });
        }
        [Fact]
        public void IfEntreeComboSideIsCorrect()
        {
            Combo c = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side = vs;
            });
        }
        [Fact]
        public void IfDrinkComboPriceIsCorrect()
        {
            Combo c = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Drink = aj;
            });
        }
        [Fact]
        public void IfEntreeComboCaloriesIsCorrect()
        {
            Combo c = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Entree = b;
            });
        }
        public void IComboSideCaloriesIsCorrect()
        {
            Combo c = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Side = vs;
            });
        }
        [Fact]
        public void IfDrinkComboCaloriesIsCorrect()
        {
            Combo c = new Combo();
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Drink = aj;
            });
        }
    }
}

    
