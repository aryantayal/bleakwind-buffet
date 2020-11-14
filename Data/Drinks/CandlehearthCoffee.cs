/*
 * Author: Aryan Tayal
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Sailor Soda drink 
 */

using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        private bool decaf;

        private bool ice;

        private bool roomForCream;

        public CandlehearthCoffee()
        {
            Size = Size.Small;
        }

        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = .75;
                        Calories = 7;
                        break;
                    case Size.Medium:
                        Price = 1.25;
                        Calories = 10;
                        break;
                    case Size.Large:
                        Price = 1.75;
                        Calories = 20;
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
        ///     get/set the room for cream
        /// </summary>
        /// <param name="roomForCream"> the bool for the cream</param>
        public bool RoomForCream
        {
            get => roomForCream;
            set
            {
                roomForCream = value;
                NotifyOfPropertyChanged("Cream");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        ///     get/set decaf
        /// </summary>
        /// <param name="decaf">decaf bool for the drink</param>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                NotifyOfPropertyChanged("Decaf");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        ///     Gets the instructions for the drink.
        /// </summary>
        /// <param name="ice">ice for drink</param>
        /// <param name="roomForCream"> the bool for the cream</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add Room for cream");
                if (Decaf) instructions.Add("Decaf");
                return instructions;
            }
        }

        /// <summary>
        /// drescription for the drink
        /// </summary>
        public override string Description => "Fair trade, fresh ground dark roast coffee.";

        /// <summary>
        ///     ToString override for the drink.
        /// </summary>
        /// <param name="size">size of the drink</param>
        public override string ToString()
        {
            if (Decaf) return Size + " Decaf Candlehearth Coffee";
            return Size + " Candlehearth Coffee";
        }
    }
}