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
    public class FriedMiraak : Side
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
                        this.Price = 1.78;
                        this.Calories = 151;
                        break;
                    case Size.Medium:
                        this.Price = 2.01;
                        this.Calories = 236;
                        break;
                    case Size.Large:
                        this.Price = 2.88;
                        this.Calories = 306;
                        break;
                }

                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("SpecialInstructions");
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