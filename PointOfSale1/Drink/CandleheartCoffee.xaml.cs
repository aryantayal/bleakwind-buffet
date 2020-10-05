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
using BleakwindBuffet.Data.Drinks;
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Drink
{
    /// <summary>
    /// Interaction logic for CandleheartCoffee.xaml
    /// </summary>
    public partial class CandleheartCoffee : UserControl
    {
        private CandlehearthCoffee cc = new CandlehearthCoffee();
        public CandleheartCoffee()
        {
            InitializeComponent();
            DataContext=cc;
        }

        /// <summary>
        /// After user selects the specification the done button it takes it back to the main menu selector
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            MenuSelector ms = new MenuSelector();
            orderControl.swapScreen(ms);
        }

        private void IceBox_OnClick(object sender, RoutedEventArgs e)
        {
            BleakwindBuffet.Data.Drinks.CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = true;
        }

        private void SizeSmallBox_OnClick(object sender, RoutedEventArgs e)
        {
            BleakwindBuffet.Data.Drinks.CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Size.Small;
        }

        private void CreamBox_OnClick(object sender, RoutedEventArgs e)
        {
            BleakwindBuffet.Data.Drinks.CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
        }

        private void DecafBox_OnClick(object sender, RoutedEventArgs e)
        {
            BleakwindBuffet.Data.Drinks.CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = true;
        }

        private void SizeMediumBox_OnClick(object sender, RoutedEventArgs e)
        {
            BleakwindBuffet.Data.Drinks.CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Size.Medium;
        }

        private void SizeLargeBox_OnClick(object sender, RoutedEventArgs e)
        {
            BleakwindBuffet.Data.Drinks.CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Size.Large;
        }

        private void ComboBox1_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is CandlehearthCoffee)
            {
                foreach (ComboBox s in e.AddedItems)
                {
                    if (s.Name == "Small") cc.Size = Size.Small;
                    if (s.Name == "Medium") cc.Size = Size.Medium;
                    if (s.Name == "Large") cc.Size = Size.Large;
                }
            }
        }
    }
}
