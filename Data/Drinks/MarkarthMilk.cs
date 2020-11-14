using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink, INotifyPropertyChanged
    {
        private bool ice;

        public MarkarthMilk()
        {
            Size = Size.Small;
        }

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
                        Price = 1.05;
                        Calories = 56;
                        break;
                    case Size.Medium:
                        Price = 1.11;
                        Calories = 72;
                        break;
                    case Size.Large:
                        Price = 1.22;
                        Calories = 93;
                        break;
                }

                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                NotifyOfPropertyChanged("Ice");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }


        /// <summary>
        ///     Gets the instructions for the drink.
        /// </summary>
        /// <param name="ice">ice</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// description for the drink
        /// </summary>
        public override string Description => "Hormone-free organic 2% milk.";

        /// <summary>
        ///     ToString override for the drink.
        /// </summary>
        /// <param name="size">size of the drink</param>
        public override string ToString()
        {
            return Size + " Markarth Milk";
        }
    }
}