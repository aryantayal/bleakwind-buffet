/*
 * Author: Aryan Tayal
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Entree
{
    public class PhillyPoacher : Entree 
    {
        
        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Gets the calories of the entree.
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Gets/sets the sirloin for the entree. 
        /// </summary>
        /// <param name="sirloin">bool for sirloin</param>
        private bool sirloin = true;
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                NotifyOfPropertyChanged("Sirloin");
                NotifyOfPropertyChanged("SpecialInstructions");
                sirloin = value;
            } 
        }

        /// <summary>
        /// Gets/sets the mushrooms for the entree. 
        /// </summary>
        /// <param name="onion">bool for onion</param>
        private bool onion = true;
        public bool Onion
        {
            get => onion;
            set  {
                NotifyOfPropertyChanged("Onion");
                NotifyOfPropertyChanged("SpecialInstructions");
                onion = value;
        }
        }

        /// <summary>
        /// Gets/sets the rolls for the entree. 
        /// </summary>
        /// <param name="roll">bool for roll</param>
        private bool roll = true;
        public bool Roll
        {
            get => roll;
            set {
                NotifyOfPropertyChanged("Roll");
                NotifyOfPropertyChanged("SpecialInstructions");
                roll = value; }
        }


        /// <summary>
        /// Gets/sets the instructions for the entree 
        /// </summary>
        /// <param name="instructions">instructions for the entree</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onion");
                if (!Roll) instructions.Add("Hold roll");
                NotifyOfPropertyChanged("SpecialInstructions");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the entree 
        /// </summary>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
