using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPay.xaml
    /// </summary>
    public partial class CashPay : UserControl
    {
        private int bill100 = 0;
        private int bill50 = 0;
        private int bill20 = 0;
        private int bill10 = 0;
        private int bill5 = 0;
        private int bill2 = 0;
        private int bill1 = 0;
        private int coin100 = 0;
        private int coin50, coin25, coin10, coin5, coin1 = 0;

        //Set the total cost to a double that will be used to compare how much is due or change
        //public double Cost = Convert.ToDouble(TotalSale.Text);

        private double totalGiven = 0;

        public CashPay()
        {
            InitializeComponent();
            Value100.Text = bill100.ToString();
            
        }

        
        

        //
        //private void 
        //Make a getter and setter for each textblock? use the top variable to assign the get?

        private void ButtonBase_OnClick(object includeSender, RoutedEventArgs includeE)
        {
            if (includeSender is Button b)
            {
                if (b.Name == "Plus100")
                {
                    bill100++;
                    totalGiven = totalGiven + 100;
                    Value100.Text = bill100.ToString();
                }

                if (b.Name == "Plus50")
                {
                    bill50++;
                    totalGiven = totalGiven + 50;
                    Value50.Text = bill50.ToString();
                }
                if (b.Name == "Plus20")
                {
                    bill20++;
                    totalGiven = totalGiven + 20;
                    Value20.Text = bill20.ToString();
                }
                if (b.Name == "Plus10")
                {
                    bill10++;
                    totalGiven = totalGiven + 10;
                    Value10.Text = bill10.ToString();
                }
                if (b.Name == "Plus5")
                {
                    bill5++;
                    totalGiven = totalGiven + 5;
                    Value5.Text = bill5.ToString();
                }
                if (b.Name == "Plus2")
                {
                    bill2++;
                    totalGiven = totalGiven + 2;
                    Value2.Text = bill2.ToString();
                }
                if (b.Name == "Plus1")
                {
                    bill1++;
                    totalGiven = totalGiven + 1;
                    Value1.Text = bill1.ToString();
                }

                if (b.Name == "Plus100c")
                {
                    coin100++;
                    totalGiven = totalGiven + 1;
                    Value1DollarCoin.Text = coin100.ToString();
                }
                if (b.Name == "Plus50c")
                {
                    coin50++;
                    totalGiven = totalGiven + .50;
                    Value50Coin.Text = coin50.ToString();
                }
                if (b.Name == "Plus25c")
                {
                    coin25++;
                    totalGiven = totalGiven + .25;
                    ValueQuarter.Text = coin25.ToString();
                }
                if (b.Name == "Plus10c")
                {
                    coin10++;
                    totalGiven = totalGiven + .10;
                    ValueDime.Text = coin10.ToString();
                }
                if (b.Name == "Plus5c")
                {
                    coin5++;
                    totalGiven = totalGiven + .05;
                    ValueNickel.Text = coin5.ToString();
                }
                if (b.Name == "Plus1c")
                {
                    coin1++;
                    totalGiven = totalGiven + .01;
                    ValuePenny.Text = coin1.ToString();
                }
            }

            if (totalGiven < Cost)
            {
                AmountDue.Text = (Cost - totalGiven).ToString();
            }
        }

        private void ButtonMinus_OnClick(object includeSender, RoutedEventArgs includeE)
        {
            if (includeSender is Button b)
            {
                if (b.Name == "Minus100")
                {
                    if (bill100 != 0)
                    {
                        bill100--;
                        totalGiven = totalGiven - 100;
                        Value100.Text = bill100.ToString();
                    }
                }

                if (b.Name == "Minus50")
                {
                    if (bill50 != 0)
                    {
                        bill50--;
                        totalGiven = totalGiven - 50;
                        Value50.Text = bill50.ToString();
                    }
                }
                if (b.Name == "Minus20")
                {
                    if (bill20 != 0)
                    {
                        bill20--;
                        totalGiven = totalGiven - 20;
                        Value20.Text = bill20.ToString();
                    }
                }
                if (b.Name == "Minus10")
                {
                    if (bill10 != 0)
                    {
                        bill10--;
                        totalGiven = totalGiven - 10;
                        Value10.Text = bill10.ToString();
                    }
                }
                if (b.Name == "Minus5")
                {
                    if (bill5 != 0)
                    {
                        bill5--;
                        totalGiven = totalGiven - 5;
                        Value5.Text = bill5.ToString();
                    }
                }
                if (b.Name == "Minus2")
                {
                    if (bill2 != 0)
                    {
                        bill2--;
                        totalGiven = totalGiven - 2;
                        Value2.Text = bill2.ToString();
                    }
                }
                if (b.Name == "Minus1")
                {
                    if (bill1 != 0)
                    {
                        bill1--;
                        totalGiven = totalGiven - 1;
                        Value1.Text = bill1.ToString();
                    }
                }

                if (b.Name == "Minus100c")
                {
                    if (coin100 != 0)
                    {
                        coin100--;
                        totalGiven = totalGiven - 1;
                        Value1DollarCoin.Text = coin100.ToString();
                    }
                }
                if (b.Name == "Minus50c")
                {
                    if (coin50 != 0)
                    {
                        coin50--;
                        totalGiven = totalGiven - .50;
                        Value50Coin.Text = coin50.ToString();
                    }
                }
                if (b.Name == "Minus25c")
                {
                    if (coin25 != 0)
                    {
                        coin25--;
                        totalGiven = totalGiven - .25;
                        ValueQuarter.Text = coin25.ToString();
                    }
                }
                if (b.Name == "Minus10c")
                {
                    if (coin10 != 0)
                    {
                        coin10--;
                        totalGiven = totalGiven - .10;
                        ValueDime.Text = coin10.ToString();
                    }
                }
                if (b.Name == "Minus5c")
                {
                    if (coin5 != 0)
                    {
                        coin5--;
                        totalGiven = totalGiven - .05;
                        ValueNickel.Text = coin5.ToString();
                    }
                }
                if (b.Name == "Minus1c")
                {
                    if (coin1 != 0)
                    {
                        coin1--;
                        totalGiven = totalGiven - .01;
                        ValuePenny.Text = coin1.ToString();
                    }
                }
            }
        }
    }
}
