﻿/*
 * Author: Aryan Tayal
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using Data.Enums;


namespace Data.Drinks
{
    class AretinoAppleJuice
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
        /// Gets the price of the drink
        /// </summary>
        public double Price
        {
            get
            {

                if (Size == Size.Medium) return .87;
                if (Size == Size.Large) return 1.01;
                return .62;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public uint Calories
        {
            get
            {

                if (Size == Size.Medium) return 88;
                if (Size == Size.Large) return 132;
                return 44;
            }
        }


        /// <summary>
        /// Gets/sets room for the ice
        /// </summary>
        private bool ice = false;
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Add ice");
                
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        public override string ToString()
        {
            return Size + " Aretino Appple Juice";
        }
    }
}