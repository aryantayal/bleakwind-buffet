/*
* Author: Aryan Tayal
* Class name: DragonbornWaffleFries.cs
* Purpose: Class used to represent the Mad Otar Grits side
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side
    {
        /// <summary>
        /// get/set for the price of the side
        /// </summary>
        /// <param name="size">size of the side</param>
        public override double Price
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
        /// /// <param name="size">size of the side</param>
        public override uint Calories
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
        /// /// <param name="instructions">the instructions for the burger</param>
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
            return Size + " Dragonborn Waffle Fries";
        }
    }
}
