/*
 * Author: Aryan Tayal
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak side
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak: Side 
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
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
            }
        }
        /// <summary>
        /// sends an empty list
        /// </summary>
        /// /// <param name="instructions">the instructions for the item</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                NotifyOfPropertyChanged("SpecialInstructions");
                return instructions;
            }
        }
        /// <summary>
        /// ToString override for the side
        /// </summary>
        public override string ToString()
        {
            return Size + " Fried Miraak";
        }
    }
}
