using System.Windows;
using System.Windows.Controls;
using BleakwindBuffet.Data;
using PointOfSale.ExtensionMethod;
using PointOfSale1;

namespace PointOfSale
{
    /// <summary>
    ///     Interaction logic for ComboPage.xaml
    /// </summary>
    public partial class ComboPage : UserControl
    {
        public ComboPage()
        {
            InitializeComponent();
            var c = new Combo();
            DataContext = c;
        }

        private void Entree_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var ep = new EntreePage((Combo) DataContext);
            orderControl.swapScreen(ep);
        }

        private void Side_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var sp = new SidePage((Combo) DataContext);
            orderControl.swapScreen(sp);
        }

        private void Drink_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var dp = new DrinkPage((Combo) DataContext);
            orderControl.swapScreen(dp);
        }

        private void ComboDone_OnClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var o = (Order) orderControl.DataContext;
            o.Add((Combo) DataContext);

            var ms = new MenuSelector();
            orderControl.swapScreen(ms);
        }
    }
}