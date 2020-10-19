using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale
{
    public class CashPayViewModel
    {
        public CashPayViewModel(double totalCost)
        {
            TotalCost = totalCost;
        }
        
        public double TotalCost
        {
            get;
            private set;
        }

        public double AmountDue
        {

        }
    }
}
