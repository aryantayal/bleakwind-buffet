using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    public class CashPayViewModel
    {
        public CashPayViewModel(double totalCost, double totalGiven)
        {
            TotalCost = totalCost;
            AmountDue = (totalCost - totalGiven);
        }
        
        public double TotalCost
        {
            get;
            private set;
        }
        
        public double AmountDue 
        {
            get;
            private set;
        }
        

    }
}
