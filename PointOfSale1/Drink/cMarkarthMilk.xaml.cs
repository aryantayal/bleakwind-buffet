using System.Windows;
using System.Windows.Controls;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Drink
{
    /// <summary>
    ///     Interaction logic for MarkarthMilk.xaml
    /// </summary>
    public partial class cMarkarthMilk : UserControl
    {
        private readonly MarkarthMilk mm = new MarkarthMilk();

        public cMarkarthMilk()
        {
            InitializeComponent();
            DataContext = mm;
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

        private void ComboBox1_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is MarkarthMilk)
                foreach (ComboBox s in e.AddedItems)
                {
                    if (s.Name == "Small") mm.Size = Size.Small;
                    if (s.Name == "Medium") mm.Size = Size.Medium;
                    if (s.Name == "Large") mm.Size = Size.Medium;
                }
        }

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