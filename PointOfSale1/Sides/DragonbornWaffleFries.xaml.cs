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
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DragonbornWaffleFries.xaml
    /// </summary>
    public partial class DragonbornWaffleFries : UserControl
    {
        private BleakwindBuffet.Data.Sides.DragonbornWaffleFries dbwf =
            new BleakwindBuffet.Data.Sides.DragonbornWaffleFries();

        public DragonbornWaffleFries()
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
            var ms = new MenuSelector();
            orderControl.swapScreen(ms);
        }

        private void ComboBox1_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is DragonbornWaffleFries)
                foreach (ComboBox s in e.AddedItems)
                {
                    if (s.Name == "Small") dbwf.Size = Size.Small;
                    if (s.Name == "Medium") dbwf.Size = Size.Medium;
                    if (s.Name == "Large") dbwf.Size = Size.Large;
                }
        }

        private void DoneComboButton_OnClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var cp = new ComboPage();
            orderControl.swapScreen(cp);
        }
    }
}