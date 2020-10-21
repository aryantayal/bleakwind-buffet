using System;
using System.Collections.Generic;
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
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Drink;
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using SailorSoda = PointOfSale.Drink.SailorSoda;
using WarriorWater = PointOfSale.Drink.WarriorWater;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkPage.xaml
    /// </summary>
    public partial class DrinkPage : UserControl
    {
        public DrinkPage(Combo c)
        {
            InitializeComponent();
            combo = c;
        }

        private Combo combo = new Combo();

        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCandlehearth_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var mo = new CandleheartCoffee();
            orderControl.swapScreen(mo);
            var item = new CandlehearthCoffee();
            //Order o = (Order)orderControl.DataContext;
            mo.DataContext = item;
            combo.Drink = item;
        }

        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bWarriorW_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var ww = new WarriorWater();
            orderControl.swapScreen(ww);
            var item = new BleakwindBuffet.Data.Drinks.WarriorWater();
            var o = (Order) orderControl.DataContext;
            ww.DataContext = item;
            combo.Drink = item;
        }

        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAretino_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var aaj = new AretinoAppleJuice();
            orderControl.swapScreen(aaj);
            var item = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
            var o = (Order) orderControl.DataContext;
            aaj.DataContext = item;
            combo.Drink = item;
        }

        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMakath_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var mm = new cMarkarthMilk();
            orderControl.swapScreen(mm);
            var item = new MarkarthMilk();
            var o = (Order) orderControl.DataContext;
            mm.DataContext = item;
            combo.Drink = item;
        }

        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSalor_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var ss = new SailorSoda();
            orderControl.swapScreen(ss);
            var item = new BleakwindBuffet.Data.Drinks.SailorSoda();
            var o = (Order) orderControl.DataContext;
            ss.DataContext = item;
            combo.Drink = item;
        }
    }
}