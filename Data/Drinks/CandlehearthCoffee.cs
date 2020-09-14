﻿/*
 * Author: Aryan Tayal
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Sailor Soda drink 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;


namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink
    {
       
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        /// /// <param name="size">size of the drink</param>
        public override double Price
        {
            get
            {

                if (Size == Size.Medium) return 1.25;
                if (Size == Size.Large) return 1.75;
                return .75;
            }
        }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        /// /// <param name="size">size of the drink</param>
        public override uint Calories
        {
            get
            {

                if (Size == Size.Medium) return 10;
                if (Size == Size.Large) return 20;
                return 7;
            }
        }


        /// <summary>
        /// Gets/sets ice for the drink.
        /// </summary>
        /// <param name="size">size of the drink</param>
        /// <param name="ice">ice</param>
        private bool ice = false;
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        private bool roomForCream = false;
        /// <summary>
        /// get/set the room for cream
        /// </summary>
        /// <param name="roomForCream"> the bool for the cream</param>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }
        private bool decaf = false;
        /// <summary>
        /// get/set decaf
        /// </summary>
        /// <param name="decaf">decaf bool for the drink</param>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        /// <param name="ice">ice for drink</param>
        /// <param name="roomForCream"> the bool for the cream</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        /// <param name="size">size of the drink</param>
        public override string ToString()
        {
            if(Decaf) return Size + " Decaf Candlehearth Coffee";
            else return Size + " Candlehearth Coffee";
        }
    }
}
