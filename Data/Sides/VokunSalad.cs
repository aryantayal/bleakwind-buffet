/*
 * Author: Aryan Tayal
 * Class name: VolkunSalad.cs
 * Purpose: Class used to represent the Vulcan Salad side
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side
    {
        
        /// <summary>
        /// get/set for the price
        /// </summary>
        /// /// <param name="size">the size</param>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
                return .93;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        /// /// <param name="size">the size</param>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 52;
                if (Size == Size.Large) return 73;
                return 41;
                
            }
        }
        /// <summary>
        /// Gets the instructions for the drink. 
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
            return Size + " Vokun Salad";
        }
    }
}
