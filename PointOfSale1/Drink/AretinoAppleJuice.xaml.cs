using System.Windows;
using System.Windows.Controls;
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale
{
    /// <summary>
    ///     Interaction logic for AretinoAppleJuice.xaml
    /// </summary>
    public partial class AretinoAppleJuice : UserControl
    {
        /// <summary>
        /// </summary>
        private readonly BleakwindBuffet.Data.Drinks.AretinoAppleJuice aj =
            new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();

        public AretinoAppleJuice()
        {
            InitializeComponent();
            //this.DataContext = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
            DataContext = aj;
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
            if (DataContext is AretinoAppleJuice)
                foreach (ComboBox s in e.AddedItems)
                {
                    if (s.Name == "Small") aj.Size = Size.Small;
                    if (s.Name == "Medium") aj.Size = Size.Medium;
                    if (s.Name == "Large") aj.Size = Size.Large;
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