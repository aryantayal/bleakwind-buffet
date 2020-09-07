/*
 * Author: Aryan Tayal
 * Class name: DoubleDragr.cs
 * Purpose: Class used to represent the Double Dragr
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Entree
{
    public class DoubleDraugr
    {
        /// <summary>
        /// Gets the price for the burger
        /// </summary>
        public double Price => 7.32;
        /// <summary>
        /// gets the calories for the burger
        /// </summary>
        public uint Calories => 843;
        private bool ketchup = true;
        /// <summary>
        /// get/set for ketchup
        /// </summary>
        /// <param name="ketchup">ketchup</param>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
            }
        }
        public bool Bun { get; set; } = true;
        /// <summary>
        /// get/set for mustard
        /// </summary>
        /// <param name="mustard">mustard for the burger</param> 
        private bool mustard = true;
        public bool Mustard
        {
            get => mustard;

            set => mustard = value;
        }
        /// <summary>
        /// get/set for pickle
        /// </summary>
        /// <param name="pickle">bool for pickle on the burger</param>
        private bool pickle = true;
        public bool Pickle
        {
            get => pickle;

            set => pickle = value;
        }
        /// <summary>
        /// get/set for cheese
        /// </summary>
        /// <param name="cheese">bool for the cheese on the burger</param>
        private bool cheese = true;
        public bool Cheese
        {
            get => cheese;

            set => cheese = value;
        }
        /// <summary>
        /// get/set for lettuce
        /// </summary>
        /// <param name="lettuce">bool for lettuce</param>
        private bool lettuce = true;
        public bool Lettuce
        {
            get => lettuce;

            set => lettuce = value;
        }
        /// <summary>
        /// get/set for tomato
        /// </summary>
        /// <param name="tomato">bool for tomato</param>
        private bool tomato = true;
        public bool Tomato
        {
            get => tomato;

            set => tomato = value;
        }
        /// <summary>
        /// get/set for mayo
        /// </summary>
        ///<param name="mayo">bool for mayo</param>
        private bool mayo = true;
        public bool Mayo
        {
            get => mayo;

            set => mayo = value;
        }

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// get/set instructions
        /// </summary>
        ///  /// <param name="instructions">the instructions for the burger</param>
        public List<string> SpecialInstructions
        {
            get {

                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }
        /// <summary>
        /// to string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }

    }
}
