/*
 * Author: Aryan Tayal
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entree
{
    public class PhillyPoacher : Entree
    {
        /// <summary>
        ///     Gets/sets the mushrooms for the entree.
        /// </summary>
        /// <param name="onion">bool for onion</param>
        private bool onion = true;

        /// <summary>
        ///     Gets/sets the rolls for the entree.
        /// </summary>
        /// <param name="roll">bool for roll</param>
        private bool roll = true;

        /// <summary>
        ///     Gets/sets the sirloin for the entree.
        /// </summary>
        /// <param name="sirloin">bool for sirloin</param>
        private bool sirloin = true;

        /// <summary>
        ///     Gets the price of the entree.
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        ///     Gets the calories of the entree.
        /// </summary>
        public override uint Calories => 784;

        public bool Sirloin
        {
            get => sirloin;
            set
            {
                sirloin = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Sirloin");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        public bool Onion
        {
            get => onion;
            set
            {
                onion = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Onion");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        public bool Roll
        {
            get => roll;
            set
            {
                roll = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Roll");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }


        /// <summary>
        ///     Gets/sets the instructions for the entree
        /// </summary>
        /// <param name="instructions">instructions for the entree</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onion");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        ///     ToString override for the entree
        /// </summary>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}