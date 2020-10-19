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
            CashPay cp = new CashPay();
            orderControl.swapScreen(cp);
        }

        private void Card_OnClick(object includeSender, RoutedEventArgs includeE)
        {
            var order = (Order)DataContext;
            var options = CardReader.RunCard(order.TotalCost);

            if (options == CardTransactionResult.Approved)
            {
                //Print reciept
                //PrintReciept();

                //Cancel order
                var payment = this.FindAncestor<MainWindow>();
                //payment.
            }
            if (options == CardTransactionResult.Declined)
            {
                MessageBox.Show("Sorry, your card has been declined");
            }
            if (options == CardTransactionResult.IncorrectPin)
            {
                MessageBox.Show("Incorrect Pin, please try again");
            }
            if (options == CardTransactionResult.InsufficientFunds)
            {
                MessageBox.Show("Insufficent Funds, please try another card");
            }
            if (options == CardTransactionResult.ReadError)
            {
                MessageBox.Show("Read Error, please try again");
            }
        }
    }
}
