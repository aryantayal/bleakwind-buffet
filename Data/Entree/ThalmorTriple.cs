/*
 * Author: Aryan Tayal
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Entree
{
    public class ThalmorTriple
    {
        /// <summary>
        /// Gets the price for the burger
        /// </summary>
        public double Price => 8.32;
        /// <summary>
        /// gets the calories for the burger
        /// </summary>
        public uint Calories => 943;
        private bool ketchup = true;

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

        private bool mustard = true;
        public bool Mustard
        {
            get => mustard;

            set => mustard = value;
        }
        private bool pickle = true;

        public bool Pickle
        {
            get => pickle;

            set => pickle = value;
        }

        private bool cheese = true;
        public bool Cheese
        {
            get => cheese;

            set => cheese = value;
        }

        private bool lettuce = true;
        public bool Lettuce
        {
            get => lettuce;

            set => lettuce = value;
        }

        private bool tomato = true;
        public bool Tomato
        {
            get => tomato;

            set => tomato = value;
        }

        private bool mayo = true;
        public bool Mayo
        {
            get => mayo;

            set => mayo = value;
        }

        private bool bacon = true;
        public bool Bacon
        {
            get => bacon;
            set => bacon = value;
        }

        private bool egg = true;

        public bool Egg
        {
            get => egg;
            set => egg = value;
        }


        private List<string> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get
            {

                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }
        public override string ToString()
        {
            return "Thalmor Triple";
        }

    }
}
