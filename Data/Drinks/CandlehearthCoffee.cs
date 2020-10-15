/*
 * Author: Aryan Tayal
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Sailor Soda drink 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        this.Price = .75;
                        this.Calories = 7;
                        break;
                    case Size.Medium:
                        this.Price = 1.25;
                        this.Calories = 10;
                        break;
                    case Size.Large:
                        this.Price = 1.75;
                        this.Calories = 20;
                        break;
                }
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }
    
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

        private bool roomForCream = false;

        /// <summary>
        /// get/set the room for cream
        /// </summary>
        /// <param name="roomForCream"> the bool for the cream</param>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                NotifyOfPropertyChanged("Cream");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private bool decaf = false;

        /// <summary>
        /// get/set decaf
        /// </summary>
        /// <param name="decaf">decaf bool for the drink</param>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                NotifyOfPropertyChanged("Decaf");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        /// <param name="ice">ice for drink</param>
        /// <param name="roomForCream"> the bool for the cream</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add Room for cream");
                if(Decaf) instructions.Add("Decaf");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        /// <param name="size">size of the drink</param>
        public override string ToString()
        {
            if (Decaf) return Size + " Decaf Candlehearth Coffee";
            else return Size + " Candlehearth Coffee";
        }
    }
}