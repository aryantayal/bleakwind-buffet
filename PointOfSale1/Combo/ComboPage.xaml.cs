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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboPage.xaml
    /// </summary>
    public partial class ComboPage : UserControl
    {
        public ComboPage()
        {
            InitializeComponent();
        }

        private void Entree_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<PointOfSale1.MainWindow>();
            EntreePage ep = new EntreePage();
            orderControl.swapScreen(ep);
        }

        private void Side_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<PointOfSale1.MainWindow>();
            SidePage sp = new SidePage();
            orderControl.swapScreen(sp);
        }

        private void Drink_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<PointOfSale1.MainWindow>();
            DrinkPage dp = new DrinkPage();
            orderControl.swapScreen(dp);
        }
    }
}
