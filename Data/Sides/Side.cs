using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// the size of the side
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// the price of the side
        /// </summary>
        /// <value>in us dollars</value>
        public abstract double Price { get; }
        /// <summary>
        /// calories for the side
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// the special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
