/*
 * Author: Aryan Tayal
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits side
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side
    {
        /// <summary>
        /// get/set for the price of the side
        /// </summary>
        /// /// <param name="size">the size</param>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 1.58;
                if (Size == Size.Large) return 1.93;
                return 1.22;
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        /// /// <param name="size">the size</param>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 142;
                if (Size == Size.Large) return 179;
                return 105;

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
