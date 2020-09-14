/*
 * Author: Aryan Tayal
 * Class: IOrderItem.cs
 * Purpose: The interface for the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data

{
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the item
        /// </summary>
        /// <value>In US dollars</value>
        double Price { get; }

        /// <summary>
        /// The calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The special instructions needed when the item is ordered
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
