/*
 * Author: Aryan Tayal
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water drink 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink , INotifyPropertyChanged
    {
       

        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Large:
                        this.Price = 0;
                        this.Calories = 0;
                        break;
                    case Size.Medium:
                        this.Price = 0;
                        this.Calories = 0;
                        break;
                    case Size.Small:
                        this.Price = 0;
                        this.Calories = 0;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
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
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChanged("Ice");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }
        private bool lemon = false;
        /// <summary>
        /// get/set the lemon
        /// </summary>
        /// <param name="lemon">bool lemon for water</param>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                NotifyOfPropertyChanged("Lemon");
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
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
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
            return Size + " Warrior Water";
        }
    }
}
