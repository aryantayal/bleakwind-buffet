/*
 * Author: Aryan Tayal
 * Class name: BrianheartBurger.cs
 * Purpose: Class used to represent the Brian heart Burger
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entree
{
    public class BriarheartBurger : Entree
    {
        private bool bun = true;

        /// <summary>
        ///     get/set for cheese
        /// </summary>
        /// <param name="cheese">bool for the cheese on the burger</param>
        private bool cheese = true;

        private bool ketchup = true;

        /// <summary>
        ///     get/set for mustard
        /// </summary>
        /// <param name="mustard">mustard for the burger</param>
        private bool mustard = true;

        private bool pickle = true;

        /// <summary>
        ///     Gets the price for the burger
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        ///     gets the calories for the burger
        /// </summary>
        public override uint Calories => 732;

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
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Bun");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        public bool Mustard
        {
            get => mustard;

            set
            {
                NotifyOfPropertyChanged("Name");
                mustard = value;
                NotifyOfPropertyChanged("Mustard");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        ///     get/set for pickle
        /// </summary>
        /// <param name="pickle">bool for pickle on the burger</param>
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

        /// <summary>
        ///     the get set for the instructions
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
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        public override string Description
        {
            get => "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
        }


        /// <summary>
        ///     to string method
        /// </summary>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}