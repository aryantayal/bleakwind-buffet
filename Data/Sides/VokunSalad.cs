/*
 * Author: Aryan Tayal
 * Class name: VolkunSalad.cs
 * Purpose: Class used to represent the Vulcan Salad side
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side
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
                        this.Price = .93;
                        this.Calories = 41;
                        break;
                    case Size.Medium:
                        this.Price = 1.28;
                        this.Calories = 52;
                        break;
                    case Size.Large:
                        this.Price = 1.82;
                        this.Calories = 73;
                        break;
                }

                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        /// /// <param name="instructions">the instructions for the item</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the side
        /// </summary>
        public override string ToString()
        {
            return Size + " Vokun Salad";
        }
    }
}