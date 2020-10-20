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
        public DrinkPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCandlehearth_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            CandleheartCoffee mo = new CandleheartCoffee();
            orderControl.swapScreen(mo);
            BleakwindBuffet.Data.Drinks.CandlehearthCoffee item = new BleakwindBuffet.Data.Drinks.CandlehearthCoffee();
            //Order o = (Order)orderControl.DataContext;
            mo.DataContext = item;
            Combo c = new Combo();
            c.Drink = item;
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bWarriorW_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            WarriorWater ww = new WarriorWater();
            orderControl.swapScreen(ww);
            BleakwindBuffet.Data.Drinks.WarriorWater item = new BleakwindBuffet.Data.Drinks.WarriorWater();
            Order o = (Order)orderControl.DataContext;
            ww.DataContext = item;
            Combo c = new Combo();
            c.Drink = item;
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAretino_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            orderControl.swapScreen(aaj);
            BleakwindBuffet.Data.Drinks.AretinoAppleJuice item = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
            Order o = (Order)orderControl.DataContext;
            aaj.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMakath_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            cMarkarthMilk mm = new cMarkarthMilk();
            orderControl.swapScreen(mm);
            BleakwindBuffet.Data.Drinks.MarkarthMilk item = new MarkarthMilk();
            Order o = (Order)orderControl.DataContext;
            mm.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSalor_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            SailorSoda ss = new SailorSoda();
            orderControl.swapScreen(ss);
            BleakwindBuffet.Data.Drinks.SailorSoda item = new BleakwindBuffet.Data.Drinks.SailorSoda();
            Order o = (Order)orderControl.DataContext;
            ss.DataContext = item;
            o.Add(item);
        }
    }
}
