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

namespace PointOfSale.Drink
{
    /// <summary>
    /// Interaction logic for MarkarthMilk.xaml
    /// </summary>
    public partial class cMarkarthMilk : UserControl
    {
        private  MarkarthMilk mm = new MarkarthMilk();
        public cMarkarthMilk()
        {
            InitializeComponent();
            DataContext = mm;
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

        private void ComboBox1_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is MarkarthMilk)
                {
                    foreach (ComboBox s in e.AddedItems)
                    {
                        if (s.Name == "Small") mm.Size = BleakwindBuffet.Data.Enums.Size.Small;
                        if (s.Name == "Medium") mm.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                        if (s.Name == "Large") mm.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    }
                }
        }
        private void Cancel_OnClick(object includeSender, RoutedEventArgs includeE)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            MenuSelector ms = new MenuSelector();
            orderControl.swapScreen(ms);
        }
    }
}
