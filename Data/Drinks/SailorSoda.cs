/*
 * Author: Aryan Tayal
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda drink 
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink
    {

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        /// <param name="size">size of the drink</param>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Large) return 2.07;
                return 1.42;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        /// <param name="size">size of the drink</param>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 153;
                if (Size == Size.Large) return 205;
                return 117;
            }
        }


        /// <summary>
        /// Gets/sets ice for the drink.
        /// </summary>
        /// <param name="ice">ice</param> 
        private bool ice = true;
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        /// <param name="flavor">flavor of the drink</param>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        /// <param name="ice">ice</param>
        /// <param name="instructions">the instructions for the drink</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        /// <param name="ice">ice</param>
        /// <param name="ice">ice</param>
        public override string ToString()
        {
            return Size + " " + Flavor + " Sailor Soda";
        }
    }
}
