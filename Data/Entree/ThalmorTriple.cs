/*
 * Author: Aryan Tayal
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple
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
    public class ThalmorTriple : Entree
    {
        /// <summary>
        /// Gets the price for the burger
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// gets the calories for the burger
        /// </summary>
        public override uint Calories => 943;

        private bool ketchup = true;

        /// <summary>
        /// get/set for ketchup
        /// </summary>
        /// <param name="ketchup">ketchup</param>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Ketchup");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// get/set for bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// get/set for mustard
        /// </summary>
        /// <param name="mustard">mustard for the burger</param>
        private bool mustard = true;

        public bool Mustard
        {
            get => mustard;

            set
            {
                mustard = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Mustard");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private bool pickle = true;

        /// <summary>
        /// get/set for pickle
        /// </summary>
        /// <param name="pickle">bool for pickle on the burger</param>
        public bool Pickle
        {
            get => pickle;

            set
            {
                pickle = value;
                NotifyOfPropertyChanged("Pickle");
                NotifyOfPropertyChanged("SpecialInstructions");

                NotifyOfPropertyChanged("Name");
            }
        }

        /// <summary>
        /// get/set for cheese
        /// </summary>
        /// <param name="cheese">bool for the cheese on the burger</param>
        private bool cheese = true;

        public bool Cheese
        {
            get => cheese;

            set
            {
                cheese = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Cheese");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// get/set for lettuce
        /// </summary>
        /// <param name="lettuce">bool for the lettuce on the burger</param>
        private bool lettuce = true;

        public bool Lettuce
        {
            get => lettuce;

            set
            {
                lettuce = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Lettuce");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// get/set for tomato
        /// </summary>
        /// <param name="tomato">bool for tomato</param>
        private bool tomato = true;

        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Tomato");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// get/set for mayo
        /// </summary>
        ///<param name="mayo">bool for mayo</param>
        private bool mayo = true;

        public bool Mayo
        {
            get => mayo;

            set
            {
                mayo = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Mayo");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// get/set for bacon
        /// </summary>
        /// <param name="bacon">bool for the bacon</param>
        private bool bacon = true;

        public bool Bacon
        {
            get => bacon;
            set
            {
                bacon = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Bacon");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private bool egg = true;

        /// <summary>
        /// get/set for egg
        /// </summary>
        /// <param name="egg">bool for the egg</param>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Egg");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }


        private List<string> specialInstructions = new List<string>();

        /// <summary>
        /// Gets/sets the instructions for the entree 
        /// </summary>
        /// <param name="instructions">the instructions for the burger</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                //NotifyOfPropertyChanged("SpecialInstructions");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the entree 
        /// </summary>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}