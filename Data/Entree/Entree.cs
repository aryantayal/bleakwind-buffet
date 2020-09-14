﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Entree
{
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// the price of the entree
        /// </summary>
        /// <value>in us dollars</value>
        public abstract double Price { get; }
        /// <summary>
        /// calories for the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// the special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}