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
using BleakwindBuffet.Data.Enums;
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Drink
{
    /// <summary>
    /// Interaction logic for SailorSoda.xaml
    /// </summary>
    public partial class SailorSoda : UserControl
    {
        private BleakwindBuffet.Data.Drinks.SailorSoda ss = new BleakwindBuffet.Data.Drinks.SailorSoda();

        public SailorSoda()
        {
            InitializeComponent();
            DataContext = ss;
        }

        /// <summary>
        /// After user selects the specification the done button it takes it back to the main menu selector
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var ms = new MenuSelector();
            orderControl.swapScreen(ms);
        }

        /*
        private void ComboBox1_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is SailorSoda)
            {
                foreach (ComboBoxItem s in e.AddedItems)
                {
                    if (s.Name == "Small") ss.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (s.Name == "Medium") ss.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (s.Name == "Large") ss.Size = Size.Large;
                }
            }
        }

        private void ComboBoxFlavor_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (ComboBoxItem s in e.AddedItems)
            {
                if (s.Name == "Blackberry") ss.Flavor = SodaFlavor.Blackberry;
                if (s.Name == "Cherry") ss.Flavor = SodaFlavor.Cherry;
                if (s.Name == "Grapefruit") ss.Flavor = SodaFlavor.Grapefruit;
                if (s.Name == "Lemon") ss.Flavor = SodaFlavor.Lemon;
                if (s.Name == "Peach") ss.Flavor = SodaFlavor.Peach;
                if (s.Name == "Watermelon") ss.Flavor = SodaFlavor.Watermelon;
            }
        }
        */
        private void Cancel_OnClick(object includeSender, RoutedEventArgs includeE)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var ms = new MenuSelector();
            orderControl.swapScreen(ms);
        }

        private void DoneComboButton_OnClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var cp = new ComboPage();
            orderControl.swapScreen(cp);
        }
    }
}