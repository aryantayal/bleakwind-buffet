/*
 * Author: Aryan Tayal
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits side
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using Data.Enums;

namespace Data.Sides
{
    class MadOtarGrits
    {
        /// <summary>
        /// Gets/sets the size of the side
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        /// <summary>
        /// get/set for the price of the side
        /// </summary>
        public double Price
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
        public uint Calories
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
        public List<string> SpecialInstructions
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
