using System;
using System.Collections.Generic;
using System.Printing;
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
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Sides
{
    /// <summary>
    /// Interaction logic for VokunSalad.xaml
    /// </summary>
    public partial class VokunSalad : UserControl
    {
        private BleakwindBuffet.Data.Sides.VokunSalad vs = new BleakwindBuffet.Data.Sides.VokunSalad();
        public VokunSalad()
        {
            InitializeComponent();
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
            if (DataContext is VokunSalad)
            {
                foreach (ComboBox s in e.AddedItems)
                {
                    if (s.Name == "Small") vs.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (s.Name == "Medium") vs.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (s.Name == "Large") vs.Size = Size.Large;
                }
            }
        }
    }
}
