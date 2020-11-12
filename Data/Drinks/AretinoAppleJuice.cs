/*
 * Author: Aryan Tayal
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink 
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink
    {
        /// <summary>
        ///     Gets/sets room for the ice
        /// </summary>
        /// <param name="ice">ice for drink</param>
        private bool ice;

        public AretinoAppleJuice()
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
                        Price = .62;
                        Calories = 44;
                        break;
                    case Size.Medium:
                        Price = 0.87;
                        Calories = 88;
                        break;
                    case Size.Large:
                        Price = 1.01;
                        Calories = 132;
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
        /// <param name="instructions">the instructions for the item</param>
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
        /// drescription for the drink
        /// </summary>
        public override string Description
        {
            get => "Fresh squeezed apple juice.";
        }
        /// <summary>
        ///     ToString override for the drink.
        /// </summary>
        /// <param name="size">size of the drink</param>
        public override string ToString()
        {
            return Size + " Aretino Apple Juice";
        }
    }
}