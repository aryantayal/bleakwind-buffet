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
using BleakwindBuffet.Data;
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentScreen.xaml
    /// </summary>
    public partial class PaymentScreen : UserControl
    {
        public PaymentScreen()
        {
            InitializeComponent();
        }

        private void Cash_OnClick(object includeSender, RoutedEventArgs includeE)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var cp = new CashPay((Order) DataContext);
            //cp.DataContext = (Order)this.DataContext;
            orderControl.swapScreen(cp);
        }

        private void Card_OnClick(object includeSender, RoutedEventArgs includeE)
        {
            var order = (Order) DataContext;
            var options = CardReader.RunCard(order.TotalCost);

            if (options == CardTransactionResult.Approved)
            {
                //Print reciept
                PrintReciept();

                //Cancel order
                ///////////order.Clear();
                var payment = this.FindAncestor<MainWindow>();
                //payment.
            }

            if (options == CardTransactionResult.Declined) MessageBox.Show("Sorry, your card has been declined");
            if (options == CardTransactionResult.IncorrectPin) MessageBox.Show("Incorrect Pin, please try again");
            if (options == CardTransactionResult.InsufficientFunds)
                MessageBox.Show("Insufficent Funds, please try another card");
            if (options == CardTransactionResult.ReadError) MessageBox.Show("Read Error, please try again");
        }

        public void PrintReciept()
        {
            var order = (Order) DataContext;
            RecieptPrinter.PrintLine("Order Number:" + order.Number.ToString());
            foreach (var item in order.Items)
            {
                RecieptPrinter.PrintLine(item.ToString() + "....$" + item.Price);
                foreach (var s in item.SpecialInstructions) RecieptPrinter.PrintLine(s);
                RecieptPrinter.PrintLine("Subtotal....$" + order.Subtotal.ToString());
                RecieptPrinter.PrintLine("Tax....$" + order.Tax.ToString());
                RecieptPrinter.PrintLine("Payment Method Used.... Card");
                RecieptPrinter.CutTape();
            }
        }
    }
}