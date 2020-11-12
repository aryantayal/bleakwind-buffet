/*
 * Author: Aryan Tayal
 * Class name: DoubleDragr.cs
 * Purpose: Class used to represent the Double Dragr
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entree
{
    public class DoubleDraugr : Entree
    {
        private bool bun = true;

        /// <summary>
        ///     get/set for cheese
        /// </summary>
        /// <param name="cheese">bool for the cheese on the burger</param>
        private bool cheese = true;

        private bool ketchup = true;

        /// <summary>
        ///     get/set for lettuce
        /// </summary>
        /// <param name="lettuce">bool for lettuce</param>
        private bool lettuce = true;

        /// <summary>
        ///     get/set for mayo
        /// </summary>
        /// <param name="mayo">bool for mayo</param>
        private bool mayo = true;

        /// <summary>
        ///     get/set for mustard
        /// </summary>
        /// <param name="mustard">mustard for the burger</param>
        private bool mustard = true;

        /// <summary>
        ///     get/set for pickle
        /// </summary>
        /// <param name="pickle">bool for pickle on the burger</param>
        private bool pickle = true;

        private List<string> specialInstructions = new List<string>();

        /// <summary>
        ///     get/set for tomato
        /// </summary>
        /// <param name="tomato">bool for tomato</param>
        private bool tomato = true;

        /// <summary>
        ///     Gets the price for the burger
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        ///     gets the calories for the burger
        /// </summary>
        public override uint Calories => 843;

        /// <summary>
        ///     get/set for ketchup
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

        public bool Bun
        {
            get => bun;
            set
            {
                bun = value;
                NotifyOfPropertyChanged("Bun");
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

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

        public bool Pickle
        {
            get => pickle;

            set
            {
                pickle = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Pickle");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

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
        ///     get/set instructions
        /// </summary>
        /// ///
        /// <param name="instructions">the instructions for the burger</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold Pickle");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }
        /// <summary>
        /// Description for the entree
        /// </summary>
        public override string Description
        {
            get => "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
        }
        /// <summary>
        ///     to string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}