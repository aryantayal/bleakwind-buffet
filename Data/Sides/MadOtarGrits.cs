/*
 * Author: Aryan Tayal
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits side
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side
    {
        /// <summary>
        /// 
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        this.Price = 1.22;
                        this.Calories = 105;
                        break;
                    case Size.Medium:
                        this.Price = 1.58;
                        this.Calories = 142;
                        break;
                    case Size.Large:
                        this.Price = 1.93;
                        this.Calories = 179;
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
        /// <param name="instructions">the instructions for the item</param>
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
            return Size + " Mad Otar Grits";
        }
    }
}