/*
 * Author: Aryan Tayal
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak side
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        /// <summary>
        /// Gets/sets the size for the side
        /// </summary>
        /// /// <param name="size">the size</param>
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
        /// /// <param name="size">the size</param>
        public double Price
        {
            get
            {
                if (Size == Size.Medium) return 2.01;
                if (Size == Size.Large) return 2.88;
                return 1.78;

            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        /// /// <param name="size">the size</param>
        public uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 236;
                if (Size == Size.Large) return 306;
                return 151;

            }
        }
        /// <summary>
        /// sends an empty list
        /// </summary>
        /// /// <param name="instructions">the instructions for the item</param>
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
