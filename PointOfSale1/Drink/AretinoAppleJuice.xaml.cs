using PointOfSale.ExtensionMethod;
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
using PointOfSale1;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuice.xaml
    /// </summary>
    public partial class AretinoAppleJuice : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private BleakwindBuffet.Data.Drinks.AretinoAppleJuice aj = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
        public AretinoAppleJuice()
        {
            InitializeComponent();
            //this.DataContext = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
            DataContext = aj;

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
            if (DataContext is AretinoAppleJuice)
            {
                foreach (ComboBox s in e.AddedItems)
                {
                    if (s.Name == "Small") aj.Size = Size.Small;
                    if (s.Name == "Medium") aj.Size = Size.Medium;
                    if (s.Name == "Large") aj.Size = Size.Large;
                }
            }
        }
    }
}
