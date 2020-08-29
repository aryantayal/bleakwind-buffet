/*
 * Author: Aryan Tayal
 * Class name: DoubleDragr.cs
 * Purpose: Class used to represent the Double Dragr
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
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
        private bool mustard = true;
        public bool Mustard
        {
            get => mustard;

            set => mustard = value;
        }
        /// <summary>
        /// get/set for pickle
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get => pickle;

            set => pickle = value;
        }
        /// <summary>
        /// get/set for cheese
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get => cheese;

            set => cheese = value;
        }
        /// <summary>
        /// get/set for lettuce
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get => lettuce;

            set => lettuce = value;
        }
        /// <summary>
        /// get/set for tomato
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get => tomato;

            set => tomato = value;
        }
        /// <summary>
        /// get/set for mayo
        /// </summary>
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
