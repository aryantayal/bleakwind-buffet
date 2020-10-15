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
    public class OrderTests
    {
        
        

        [Fact]
        public void ShouldCalculateCorrectSubTotalTaxCostAndTotal()
        {
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            Order o = new Order();

            o.Add((IOrderItem)b);

            Assert.Equal(6.48, o.Subtotal, 2);
            Assert.Equal(0.324, o.Tax, 2);
            Assert.Equal(6.804, o.TotalCost, 2);
        }

        [Fact]
        public void ShouldCalculateCorrectSubTotalTaxCostAndTotalForSide()
        {
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            Order o = new Order();
            vs.Size = Size.Small;
            o.Add((IOrderItem)vs);

            Assert.Equal(.93, o.Subtotal, 2);
            Assert.Equal(.01116, o.Tax, 2);
            Assert.Equal(.941, o.TotalCost, 2);
        }
        [Fact]
        public void ShouldCalculateCorrectSubTotalTaxCostAndTotalForDrink()
        {
            BriarheartBurger b = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            Order o = new Order();
            aj.Size = Size.Small;
            o.Add((IOrderItem)aj);
            Assert.Equal(.62, o.Subtotal, 2);
            Assert.Equal(.07, o.Tax, 2);
            Assert.Equal(.68, o.TotalCost, 2);
        }

    }
}