using System;
using System.ComponentModel;
using RoundRegister;
/// <summary>
/// this class is the view model for the cash register
/// </summary>
namespace PointOfSale
{
    public class CashPayViewModel : INotifyPropertyChanged
    {
        #region private variables
        private double orderCost = 0;
        private int Paid100c;
        private int Paid10c;
        private int Paid1c;
        private int Paid25c;
        private int Paid50c;
        private int Paid5c;
        private int paidFifties;
        private int paidFives;
        private int paidHundreds;
        private int paidOnes;
        private int paidTens;
        private int paidTwenties;
        private int paidTwos;
        private bool sufficientPayment;
        private int Change1c;
        private int Change25c;
        private int Change50c;
        private int Change5c;
        private double changeDue;
        private int chgFifties;
        private int chgFives;
        private int chgHundreds;
        private int chgOnes;
        private int chgTens;
        private int chgTwenties;
        private int chgTwos;
        private double currentPayment;
        private double amountDue;
        private int Change100c;
        private int Change10c;
        #endregion

        public CashPayViewModel(double totalCost)
        {
            TotalCost = totalCost;
        }

        public double TotalCost { get; }

        /// <summary>
        ///     Holds if there is sufficient funds to pay for the meal
        /// </summary>
        public bool EnoughMoney
        {
            get
            {
                if (CurrentPayment >= TotalCost) sufficientPayment = true;
                else sufficientPayment = false;

                return sufficientPayment;
            }
        }

        /// <summary>
        ///     The current payment amount
        /// </summary>
        public double CurrentChangeDue => TotalCost - CurrentPayment;

        /// <summary>
        ///     The current payment amount
        /// </summary>
        public double CurrentPayment
        {
            get
            {
                currentPayment = Paid1c * 0.01 + Paid5c * 0.05 + Paid10c * 0.10 + Paid25c * 0.25 +
                                 Paid50c * 0.50 + Paid100c * 1.0 + PaidOnes * 1.00 + PaidTwos * 2.00 +
                                 PaidFives * 5.00 + PaidTens * 10.00 + PaidTwenties * 20.0 + PaidFifties * 50.0 +
                                 PaidHundreds * 100.0;
                return currentPayment;
            }
        }
        /// <summary>
        /// Calculates the amount due
        /// </summary>
        public double AmountDue
        {
            get
            {
                if (CurrentPayment > 0)
                    amountDue = TotalCost - CurrentPayment;
                else amountDue = TotalCost;

                return amountDue;
            }
        }

        #region Cashregister

        /// <summary>
        ///     The Pennies contained within the CashDrawer
        /// </summary>
        public int Pennies
        {
            get => CashDrawer.Pennies;
            set => CashDrawer.Pennies = value;
        }

        /// <summary>
        ///     The Nickels contained within the CashDrawer
        /// </summary>
        public int Nickels
        {
            get => CashDrawer.Nickels;
            set => CashDrawer.Nickels = value;
        }

        /// <summary>
        ///     The Dimes contained within the CashDrawer
        /// </summary>
        public int Dimes
        {
            get => CashDrawer.Dimes;
            set => CashDrawer.Dimes = value;
        }

        /// <summary>
        ///     The Quarters contained within the CashDrawer
        /// </summary>
        public int Quarters
        {
            get => CashDrawer.Quarters;
            set => CashDrawer.Quarters = value;
        }

        /// <summary>
        ///     The Dollars contained within the CashDrawer
        /// </summary>
        public int Dollars
        {
            get => CashDrawer.Dollars;
            set => CashDrawer.Dollars = value;
        }

        /// <summary>
        ///     The HalfDollars contained within the CashDrawer
        /// </summary>
        public int HalfDollars
        {
            get => CashDrawer.HalfDollars;
            set => CashDrawer.HalfDollars = value;
        }

        /// <summary>
        ///     The Ones contained within the CashDrawer
        /// </summary>
        public int Ones
        {
            get => CashDrawer.Ones;
            set => CashDrawer.Ones = value;
        }

        /// <summary>
        ///     The Twos contained within the CashDrawer
        /// </summary>
        public int Twos
        {
            get => CashDrawer.Twos;
            set => CashDrawer.Twos = value;
        }

        /// <summary>
        ///     The Fives contained within the CashDrawer
        /// </summary>
        public int Fives
        {
            get => CashDrawer.Fives;
            set => CashDrawer.Fives = value;
        }

        /// <summary>
        ///     The Tens contained within the CashDrawer
        /// </summary>
        public int Tens
        {
            get => CashDrawer.Tens;
            set => CashDrawer.Tens = value;
        }

        /// <summary>
        ///     The Twenties contained within the CashDrawer
        /// </summary>
        public int Twenties
        {
            get => CashDrawer.Twenties;
            set => CashDrawer.Twenties = value;
        }

        /// <summary>
        ///     The Fifties contained within the CashDrawer
        /// </summary>
        public int Fifties
        {
            get => CashDrawer.Fifties;
            set => CashDrawer.Fifties = value;
        }

        /// <summary>
        ///     The Hundreds contained within the CashDrawer
        /// </summary>
        public int Hundreds
        {
            get => CashDrawer.Hundreds;
            set => CashDrawer.Hundreds = value;
        }

        #endregion


        /// <summary>
        ///     The Total contained within the CashDrawer
        /// </summary>
        public double Total => CashDrawer.Total;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Calculates the coins needed for change
        /// </summary>
        public void CalculateChange()
        {
            if (CurrentPayment > TotalCost && EnoughMoney)
            {
                changeDue = Math.Round(CurrentPayment - TotalCost, 2);

                var payment = (int) changeDue;

                var paymentChange = Math.Round(changeDue - payment, 2);
                ChangeHundreds = payment / 100;
                payment %= 100;
                ChangeFifties = payment / 50;
                payment %= 50;
                ChangeTwenties = payment / 20;
                payment %= 20;
                ChangeTens = payment / 10;
                payment %= 10;
                ChangeFives = payment / 5;
                payment %= 5;
                ChangeTwos = payment / 2;
                payment %= 2;
                ChangeOnes = payment;
                ChangeDollars = 0;
                ChangeHalfDollars = (int) (paymentChange / 0.50);
                paymentChange %= 0.50;
                ChangeQuarters = (int) (paymentChange / 0.25);
                paymentChange %= 0.25;
                ChangeDimes = (int) (paymentChange / 0.10);
                paymentChange %= 0.10;
                ChangeNickels = (int) (paymentChange / 0.05);
                paymentChange %= 0.05;
                ChangePennies = (int) (paymentChange / 0.01);
            }
            else
            {
                //CurrentChangeDue = 0;
                ChangeHundreds = 0;
                ChangeFifties = 0;
                ChangeTwenties = 0;
                ChangeTens = 0;
                ChangeFives = 0;
                ChangeTwos = 0;
                ChangeOnes = 0;

                ChangeDollars = 0;
                ChangeHalfDollars = 0;
                ChangeQuarters = 0;
                ChangeDimes = 0;
                ChangeNickels = 0;
                ChangePennies = 0;
            }
        }

        /// <summary>
        ///     Opens the Drawer of the register
        /// </summary>
        public void OpenDrawer()
        {
            CashDrawer.OpenDrawer();
        }

        /// <summary>
        ///     Resets the drawer of the register
        /// </summary>
        public void ResetDrawer()
        {
            CashDrawer.ResetDrawer();
        }

        /// <summary>
        ///     Finalizes the sale
        /// </summary>
        public void FinalizeSale()
        {
            Pennies = Pennies - ChangePennies + Paid1C;
            Nickels = Nickels - ChangeNickels + Paid5C;
            Dimes = Dimes - ChangeDimes + Paid10C;
            Quarters = Quarters - ChangeQuarters + Paid25C;
            HalfDollars = HalfDollars - ChangeHalfDollars + Paid50C;
            Dollars = Dollars - ChangeDollars + Paid100C;
            Ones = Ones - ChangeOnes + PaidOnes;
            Twos = Twos - ChangeTwos + PaidTwos;
            Fives = Fives - ChangeFives + PaidFives;
            Tens = Tens - ChangeTens + PaidTens;
            Twenties = Twenties - ChangeTwenties + PaidTwenties;
            Fifties = Fifties - ChangeFifties + PaidFifties;
            Hundreds = Hundreds - ChangeHundreds + PaidHundreds;
        }

        #region PaidCurrency

        /// <summary>
        ///     The Pennies paid
        /// </summary>
        public int Paid1C
        {
            get => Paid1c;
            set
            {
                Paid1c = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid1C"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));

                CalculateChange();
            }
        }

        /// <summary>
        ///     The Nickels paid
        /// </summary>
        public int Paid5C
        {
            get => Paid5c;
            set
            {
                Paid5c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid5C"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        /// <summary>
        ///     The Dimes paid
        /// </summary>
        public int Paid10C
        {
            get => Paid10c;
            set
            {
                Paid10c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid10C"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        /// <summary>
        ///     The Quarters paid
        /// </summary>
        public int Paid25C
        {
            get => Paid25c;
            set
            {
                Paid25c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid25C"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        /// <summary>
        ///     The Dollars paid
        /// </summary>
        public int Paid100C
        {
            get => Paid100c;
            set
            {
                Paid100c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid100C"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        /// <summary>
        ///     The HalfDollars paid
        /// </summary>
        public int Paid50C
        {
            get => Paid50c;
            set
            {
                Paid50c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid50C"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        /// <summary>
        ///     The Ones paid
        /// </summary>
        public int PaidOnes
        {
            get => paidOnes;
            set
            {
                paidOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        /// <summary>
        ///     The Twos paid
        /// </summary>
        public int PaidTwos
        {
            get => paidTwos;
            set
            {
                paidTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        /// <summary>
        ///     The Fives paid
        /// </summary>
        public int PaidFives
        {
            get => paidFives;
            set
            {
                paidFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        /// <summary>
        ///     The Tens paid
        /// </summary>
        public int PaidTens
        {
            get => paidTens;
            set
            {
                paidTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        /// <summary>
        ///     The Twenties paid
        /// </summary>
        public int PaidTwenties
        {
            get => paidTwenties;
            set
            {
                paidTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        /// <summary>
        ///     The Fifties paid
        /// </summary>
        public int PaidFifties
        {
            get => paidFifties;
            set
            {
                paidFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        /// <summary>
        ///     The Hundreds paid
        /// </summary>
        public int PaidHundreds
        {
            get => paidHundreds;
            set
            {
                paidHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SufficientPayment"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                CalculateChange();
            }
        }

        #endregion

        #region ChangeProperties

        /// <summary>
        ///     The Pennies for change
        /// </summary>
        public int ChangePennies
        {
            get => Change1c;
            set
            {
                Change1c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The Nickels for change
        /// </summary>
        public int ChangeNickels
        {
            get => Change5c;
            set
            {
                Change5c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The Dimes for change
        /// </summary>
        public int ChangeDimes
        {
            get => Change10c;
            set
            {
                Change10c = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The Quarters for change
        /// </summary>
        public int ChangeQuarters
        {
            get => Change25c;
            set
            {
                Change25c = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The Dollars for change
        /// </summary>
        public int ChangeDollars
        {
            get => Change100c;
            set
            {
                Change100c = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The HalfDollars for change
        /// </summary>
        public int ChangeHalfDollars
        {
            get => Change50c;
            set
            {
                Change50c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The Ones for change
        /// </summary>
        public int ChangeOnes
        {
            get => chgOnes;
            set
            {
                chgOnes = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The Twos for change
        /// </summary>
        public int ChangeTwos
        {
            get => chgTwos;
            set
            {
                chgTwos = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The Fives for change
        /// </summary>
        public int ChangeFives
        {
            get => chgFives;
            set
            {
                chgFives = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The Tens for change
        /// </summary>
        public int ChangeTens
        {
            get => chgTens;
            set
            {
                chgTens = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The Twenties for change
        /// </summary>
        public int ChangeTwenties
        {
            get => chgTwenties;
            set
            {
                chgTwenties = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The Fifties for change
        /// </summary>
        public int ChangeFifties
        {
            get => chgFifties;
            set
            {
                chgFifties = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        /// <summary>
        ///     The Hundreds for change
        /// </summary>
        public int ChangeHundreds
        {
            get => chgHundreds;
            set
            {
                chgHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentChangeDue"));
            }
        }

        #endregion
    }
}