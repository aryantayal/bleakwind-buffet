using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink , INotifyPropertyChanged 
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        this.Price = 1.05;
                        this.Calories = 56;
                        break;
                    case Size.Medium:
                        this.Price = 1.11;
                        this.Calories = 72;
                        break;
                    case Size.Large:
                        this.Price = 1.22;
                        this.Calories = 93;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }
        /*
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        /// /// <param name="size">size of the drink</param>
         public override double Price
        {
            get
            {
                
                if (Size == Size.Medium) return 1.11;
                if (Size == Size.Large) return 1.22;
                return 1.05;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        /// /// <param name="size">size of the drink</param>
        public override uint Calories
        {
            get
            {
                
                if (Size == Size.Medium) return 72;
                if (Size == Size.Large) return 93;
                return 56;
            }
        }
        */

        /// <summary>
        /// Gets/sets ice for the drink.
        /// </summary>
        /// <param name="ice">ice</param>
        private bool ice = false;
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChanged("Ice");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }


        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        /// <param name="ice">ice</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Add ice");
                NotifyOfPropertyChanged("SpecialInstructions");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        /// <param name="size">size of the drink</param>
        public override string ToString()
        {
            return Size + " Markarth Milk";
        }
    }
}

