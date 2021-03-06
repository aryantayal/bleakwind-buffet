﻿/*
* Author: Aryan Tayal
* Class name: DragonbornWaffleFries.cs
* Purpose: Class used to represent the Mad Otar Grits side
*/

using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side
    {
        public DragonbornWaffleFries()
        {
            Size = Size.Small;
        }

        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = .42;
                        Calories = 77;
                        break;
                    case Size.Medium:
                        Price = 0.76;
                        Calories = 89;
                        break;
                    case Size.Large:
                        Price = 0.96;
                        Calories = 100;
                        break;
                }

                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// drescription for the side
        /// </summary>
        public override string Description => "Crispy fried potato waffle fries.";

        /// <summary>
        ///     sends an empty list
        /// </summary>
        /// ///
        /// <param name="instructions">the instructions for the burger</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        ///     ToString override for the side
        /// </summary>
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}