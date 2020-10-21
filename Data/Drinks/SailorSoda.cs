/*
 * Author: Aryan Tayal
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda drink 
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, INotifyPropertyChanged
    {
        public SailorSoda()
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
                        Price = 1.42;
                        Calories = 117;
                        break;
                    case Size.Medium:
                        Price = 1.74;
                        Calories = 153;
                        break;
                    case Size.Large:
                        Price = 2.07;
                        Calories = 205;
                        break;
                }

                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }


        /// <summary>
        /// Gets/sets ice for the drink.
        /// </summary>
        /// <param name="ice">ice</param> 
        private bool ice = true;

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
        /// Gets the price of the drink
        /// </summary>
        /// <param name="flavor">flavor of the drink</param>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Flavor");
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        /// <param name="ice">ice</param>
        /// <param name="instructions">the instructions for the drink</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        /// <param name="ice">ice</param>
        /// <param name="ice">ice</param>
        public override string ToString()
        {
            return Size + " " + Flavor + " Sailor Soda";
        }
    }
}