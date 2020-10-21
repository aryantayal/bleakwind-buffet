using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
using BleakwindBuffet.Data;
using PointOfSale.ExtensionMethod;
using PointOfSale1;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPay.xaml
    /// </summary>
    public partial class CashPay : UserControl
    {
        private void ReturnToOrder_Click(object sender, RoutedEventArgs e)
        {
            var x = this.FindAncestor<MainWindow>();
            x.swapScreen(new MenuSelector());
        }


        private double totalGiven = 0;


        public CashPay(Order order)
        {
            InitializeComponent();
            DataContext = order;
            if (DataContext is Order o)
            {
                var cpv = new CashPayViewModel(o.TotalCost);
                DataContext = cpv;
            }
        }
    }
}