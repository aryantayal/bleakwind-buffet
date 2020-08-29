﻿/*
 * Author: Aryan Tayal
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water drink 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using Data.Enums;

namespace Data.Drinks
{
    class WarriorWater
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
                return 0;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets/sets ice for the drink.
        /// </summary>
        private bool ice = true;
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        private bool lemon = false;
        /// <summary>
        /// get/set the lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (!Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        public override string ToString()
        {
            return Size + " Warrior Water";
        }
    }
}