using System.Windows;
using System.Windows.Controls;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Drink
{
    /// <summary>
    ///     Interaction logic for CandleheartCoffee.xaml
    /// </summary>
    public partial class CandleheartCoffee : UserControl
    {
        private readonly CandlehearthCoffee cc = new CandlehearthCoffee();

        public CandleheartCoffee()
        {
            InitializeComponent();
            DataContext = cc;
        }

        /// <summary>
        ///     After user selects the specification the done button it takes it back to the main menu selector
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var ms = new MenuSelector();
            orderControl.swapScreen(ms);
        }

        private void IceBox_OnClick(object sender, RoutedEventArgs e)
        {
            var cc = new CandlehearthCoffee();
            cc.Ice = true;
        }


        private void CreamBox_OnClick(object sender, RoutedEventArgs e)
        {
            var cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
        }

        private void DecafBox_OnClick(object sender, RoutedEventArgs e)
        {
            var cc = new CandlehearthCoffee();
            cc.Decaf = true;
        }

        private void ComboBox1_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is CandlehearthCoffee)
                foreach (ComboBox s in e.AddedItems)
                {
                    if (s.Name == "Small") cc.Size = Size.Small;
                    if (s.Name == "Medium") cc.Size = Size.Medium;
                    if (s.Name == "Large") cc.Size = Size.Large;
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