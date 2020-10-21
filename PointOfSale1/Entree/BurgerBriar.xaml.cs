using System.Windows;
using System.Windows.Controls;
using PointOfSale.ExtensionMethod;
using PointOfSale1;

namespace PointOfSale
{
    /// <summary>
    ///     Interaction logic for BurgerBriar.xaml
    /// </summary>
    public partial class BurgerBriar : UserControl
    {
        public BurgerBriar()
        {
            InitializeComponent();
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

        private void DoneComboButton_OnClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var cp = new ComboPage();
            orderControl.swapScreen(cp);
        }
    }
}