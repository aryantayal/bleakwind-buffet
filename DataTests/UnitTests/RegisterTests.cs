/*
 * Author: Aryan Tayal
 * Class: RegisterTests.cs
 * Purpose: Test the RegisterTests.cs class in the Data library
 */

using System.ComponentModel;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using PointOfSale;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class RegisterTests
    {
        [Fact]
        public void ShouldBeAnINofityPropertyChanged()
        {
            double test = 0;
            var drawer = new CashPayViewModel(test);
            drawer.ResetDrawer();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drawer);
        }

        [Fact]
        public void Defaults_Should_Be_Zero_ChangeAndPaid()
        {
            double test = 0;
            var drawer = new CashPayViewModel(test);
            drawer.ResetDrawer();
            Assert.Equal(0, drawer.ChangePennies);
            Assert.Equal(0, drawer.ChangeNickels);
            Assert.Equal(0, drawer.ChangeDimes);
            Assert.Equal(0, drawer.ChangeQuarters);
            Assert.Equal(0, drawer.ChangeHalfDollars);
            Assert.Equal(0, drawer.ChangeDollars);
            Assert.Equal(0, drawer.ChangeOnes);
            Assert.Equal(0, drawer.ChangeTwos);
            Assert.Equal(0, drawer.ChangeFives);
            Assert.Equal(0, drawer.ChangeTens);
            Assert.Equal(0, drawer.ChangeTwenties);
            Assert.Equal(0, drawer.ChangeFifties);
            Assert.Equal(0, drawer.ChangeHundreds);
            Assert.Equal(0, drawer.CurrentPayment);
            Assert.Equal(0, drawer.CurrentChangeDue);
            Assert.Equal(0, drawer.AmountDue);
            Assert.Equal(0, drawer.Paid1C);
            Assert.Equal(0, drawer.Paid5C);
            Assert.Equal(0, drawer.Paid10C);
            Assert.Equal(0, drawer.Paid25C);
            Assert.Equal(0, drawer.Paid50C);
            Assert.Equal(0, drawer.Paid100C);
            Assert.Equal(0, drawer.PaidOnes);
            Assert.Equal(0, drawer.PaidTwos);
            Assert.Equal(0, drawer.PaidFives);
            Assert.Equal(0, drawer.PaidTens);
            Assert.Equal(0, drawer.PaidTwenties);
            Assert.Equal(0, drawer.PaidFifties);
            Assert.Equal(0, drawer.PaidHundreds);

            Assert.Equal(474, drawer.Total);
        }

        [Fact]
        public void Defaults_Should_Be_ZeroEnoughMoney()
        {
            double test = 0;
            var drawer = new CashPayViewModel(test);
            drawer.ResetDrawer();
            Assert.Equal(0, drawer.TotalCost);
            Assert.True(drawer.EnoughMoney);
        }
    }
}