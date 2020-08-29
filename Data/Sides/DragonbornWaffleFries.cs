/*
* Author: Aryan Tayal
* Class name: DragonbornWaffleFries.cs
* Purpose: Class used to represent the Mad Otar Grits side
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using Data.Enums;

namespace Data.Sides
{
    class DragonbornWaffleFries
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
                if (Size == Size.Medium) return .76;
                if (Size == Size.Large) return .96;
                return .42;
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 89;
                if (Size == Size.Large) return 100;
                return 77;

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
            return Size + " Dragonborn Waffle Fries";
        }
    }
}
