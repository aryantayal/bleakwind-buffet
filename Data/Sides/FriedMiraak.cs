/*
 * Author: Aryan Tayal
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak side
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using Data.Enums;
namespace Data.Sides
{
    class FriedMiraak
    {
        /// <summary>
        /// Gets/sets the size for the side
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
        /// get/set for the price
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Medium) return 2.88;
                if (Size == Size.Large) return 2.01;
                return 1.78;
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
            return Size + " Fried Miraak";
        }
    }
}
