/*
 * Author: Aryan Tayal
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink  
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
        /// Gets the price of the drink
        /// </summary>
        /// <param name="size"> the size</param>
        /// <param name="price">the price based on the size</param>
        public override double Price
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
        /// <param name="size"> the size</param>
        /// <param name="price">the price based on the size</param>
        public override uint Calories
        {
            get
            {

                if (Size == Size.Medium) return 88;
                if (Size == Size.Large) return 132;
                return 44;
            }
        }
        */

        /// <summary>
        /// Gets/sets room for the ice
        /// </summary>
        /// <param name="ice">ice for drink</param>
        private bool ice = false;

        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChanged("Ice");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
            
        }
        

        /// <summary>
        /// Gets the instructions for the drink. 
        /// </summary>
        /// <param name="instructions">the instructions for the item</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                NotifyOfPropertyChanged("SpecialInstructions");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the drink. 
        /// </summary>
        /// <param name="size">size of the drink</param>
        public override string ToString()
        {
            return Size + " Aretino Apple Juice";
        }
    }
}
