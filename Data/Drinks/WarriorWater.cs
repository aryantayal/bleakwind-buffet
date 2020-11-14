/*
 * Author: Aryan Tayal
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water drink 
 */

using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, INotifyPropertyChanged
    {
        /// <summary>
        ///     Gets/sets ice for the drink.
        /// </summary>
        /// <param name="ice">ice</param>
        private bool ice = true;

        private bool lemon;

        public WarriorWater()
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
                    case Size.Large:
                        Price = 0;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = 0;
                        Calories = 0;
                        break;
                    case Size.Small:
                        Price = 0;
                        Calories = 0;
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
        ///     get/set the lemon
        /// </summary>
        /// <param name="lemon">bool lemon for water</param>
        public bool Lemon
        {
            get => lemon;
            set
            {
                lemon = value;
                NotifyOfPropertyChanged("Lemon");
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
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// drescription for the drink
        /// </summary>
        public override string Description => "It’s water. Just water.";

        /// <summary>
        ///     ToString override for the drink.
        /// </summary>
        /// <param name="size">size of the drink</param>
        public override string ToString()
        {
            return Size + " Warrior Water";
        }
    }
}