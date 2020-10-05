/*
* Author: Aryan Tayal
* Class name: DragonbornWaffleFries.cs
* Purpose: Class used to represent the Mad Otar Grits side
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side 
    {
        

        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        this.Price = .62;
                        this.Calories = 44;
                        break;
                    case Size.Medium:
                        this.Price = 0.87;
                        this.Calories = 88;
                        break;
                    case Size.Large:
                        this.Price = 1.01;
                        this.Calories = 132;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }
        /*
        /// <summary>
        /// get/set for the price of the side
        /// </summary>
        /// <param name="size">size of the side</param>
        public override double Price
        {
            get
            {
                double price = 0;
                if (Size == Size.Medium)
                {
                    price = .76;
                    
                }
                if (Size == Size.Large) return .96;
                return .42;
            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        /// /// <param name="size">size of the side</param>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium) return 89;
                if (Size == Size.Large) return 100;
                return 77;

            }
        }
        */
        /// <summary>
        /// sends an empty list
        /// </summary>
        /// /// <param name="instructions">the instructions for the burger</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                NotifyOfPropertyChanged("SpecialInstruction");
                return instructions;
            }
        }
        /// <summary>
        /// ToString override for the side
        /// </summary>
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }
    }
}
