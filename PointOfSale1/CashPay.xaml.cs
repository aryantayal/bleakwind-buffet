using System.Windows;
using System.Windows.Controls;
using BleakwindBuffet.Data;
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    ///     Interaction logic for CashPay.xaml
    /// </summary>
    public partial class CashPay : UserControl
    {
        private CashPayViewModel drawer;

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

        private void ReturnToOrder_Click(object sender, RoutedEventArgs e)
        {
            var x = this.FindAncestor<MainWindow>();
            x.swapScreen(new MenuSelector());
        }

        private void FinalizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (drawer.EnoughMoney)
            {
                drawer.OpenDrawer();
                drawer.FinalizeSale();
                PrintReciept();
            }
        }

        public void PrintReciept()
        {
            var order = (Order) DataContext;
            RecieptPrinter.PrintLine("Order Number:" + order.Number);
            foreach (var item in order.Items)
            {
                RecieptPrinter.PrintLine(item + "....$" + item.Price);
                foreach (var s in item.SpecialInstructions) RecieptPrinter.PrintLine(s);
                RecieptPrinter.PrintLine("Subtotal....$" + order.Subtotal);
                RecieptPrinter.PrintLine("Tax....$" + order.Tax);
                RecieptPrinter.PrintLine("Payment Method Used.... Cash");
                RecieptPrinter.CutTape();
            }
        }
    }
}