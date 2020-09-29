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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BurgerBriar.xaml
    /// </summary>
    public partial class BurgerBriar : UserControl
    {
        public BurgerBriar()
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
    }
}
