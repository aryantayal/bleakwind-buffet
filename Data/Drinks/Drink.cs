using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/// <summary>
/// a base class representing the common properties of drinks
/// </summary>
namespace BleakwindBuffet.Data.Drinks
{
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// the size of the drink
        /// </summary>
        public virtual Size Size { get; set;}
        /// <summary>
        /// the price of the drink
        /// </summary>
        /// <value>in us dollars</value>
        public  abstract double Price { get; }
        /// <summary>
        /// calories for the drink
        /// </summary>
        public  abstract  uint Calories { get; }
        /// <summary>
        /// the special instructions to prepare the drink
        /// </summary>
        public  abstract  List<string> SpecialInstructions { get; }




    }
}
