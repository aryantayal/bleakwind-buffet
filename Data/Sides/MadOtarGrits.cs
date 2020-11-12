/*
 * Author: Aryan Tayal
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits side
 */

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side
    {
        public MadOtarGrits()
        {
            Size = Size.Small;
        }

        /// <summary>
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
                        Price = 1.22;
                        Calories = 105;
                        break;
                    case Size.Medium:
                        Price = 1.58;
                        Calories = 142;
                        break;
                    case Size.Large:
                        Price = 1.93;
                        Calories = 179;
                        break;
                }

                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        ///     sends an empty list
        /// </summary>
        /// <param name="instructions">the instructions for the item</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// drescription for the side
        /// </summary>
        public override string Description
        {
            get => "Cheesey Grits.";
        }
        /// <summary>
        ///     ToString override for the side
        /// </summary>
        public override string ToString()
        {
            return Size + " Mad Otar Grits";
        }
    }
}