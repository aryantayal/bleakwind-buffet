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
    public class VokunSalad
    {
     /// <summary>
     /// Gets/sets the size of the drink.
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
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
                return .93;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public uint Calories
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
            return Size + " Vokun Salad";
        }
    }
}
