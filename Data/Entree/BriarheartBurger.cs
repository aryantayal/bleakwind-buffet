﻿/*
 * Author: Aryan Tayal
 * Class name: BrianheartBurger.cs
 * Purpose: Class used to represent the Brian heart Burger
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price for the burger
        /// </summary>
        public double Price => 6.32;
        /// <summary>
        /// gets the calories for the burger
        /// </summary>
        public uint Calories => 732;

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
        private bool pickle = true;
        /// <summary>
        /// get/set for pickle
        /// </summary>
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

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// the get set for the instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get {

                List<string> instructions = new List<string>(specialInstructions);
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }
        /// <summary>
        /// to string method
        /// </summary>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }
}