/*
 * Author: Aryan Tayal
 * Class: OrderTests.cs
 * Purpose: Test the OrderTests.cs class in the Data library
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldCalculateCorrectSubTotalTaxCostAndTotal()
        {
            var b = new BriarheartBurger();
            var aj = new AretinoAppleJuice();
            var vs = new VokunSalad();
            var o = new Order();

            o.Add(b);

            Assert.Equal(6.32, o.Subtotal, 2);
            Assert.Equal(0.76, o.Tax, 2);
            Assert.Equal(7.08, o.TotalCost, 2);
        }

        [Fact]
        public void ShouldCalculateCorrectSubTotalTaxCostAndTotalForSide()
        {
            var b = new BriarheartBurger();
            var aj = new AretinoAppleJuice();
            var vs = new VokunSalad();
            var o = new Order();
            vs.Size = Size.Small;
            o.Add(vs);

            Assert.Equal(.93, o.Subtotal, 2);
            Assert.Equal(.11, o.Tax, 2);
            Assert.Equal(1.04, o.TotalCost, 2);
        }

        [Fact]
        public void ShouldCalculateCorrectSubTotalTaxCostAndTotalForDrink()
        {
            var b = new BriarheartBurger();
            var aj = new AretinoAppleJuice();
            var vs = new VokunSalad();
            var o = new Order();
            aj.Size = Size.Small;
            o.Add(aj);
            Assert.Equal(.62, o.Subtotal, 2);
            Assert.Equal(.07, o.Tax, 2);
            Assert.Equal(.69, o.TotalCost, 2);
        }
    }
}