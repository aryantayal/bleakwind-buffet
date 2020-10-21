using System.Windows;
using System.Windows.Controls;
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Sides
{
    /// <summary>
    ///     Interaction logic for FriedMiraak.xaml
    /// </summary>
    public partial class FriedMiraak : UserControl
    {
        private readonly BleakwindBuffet.Data.Sides.FriedMiraak fm = new BleakwindBuffet.Data.Sides.FriedMiraak();

        public FriedMiraak()
        {
            InitializeComponent();
            DataContext = fm;
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
            if (DataContext is FriedMiraak)
                foreach (ComboBox s in e.AddedItems)
                {
                    if (s.Name == "Small") fm.Size = Size.Small;
                    if (s.Name == "Medium") fm.Size = Size.Medium;
                    if (s.Name == "Large") fm.Size = Size.Large;
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