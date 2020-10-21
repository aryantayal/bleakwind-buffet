/*
 * Author: Aryan Tayal
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entree
{
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        ///     Gets/sets the eggs for the entree.
        /// </summary>
        /// <param name="egg">bool for egg</param>
        private bool egg = true;

        /// <summary>
        ///     Gets/sets the hash browns for the entree.
        /// </summary>
        /// <param name="hashbrown">bool for hashbrown</param>
        private bool hashBrowns = true;

        /// <summary>
        ///     Gets/sets the pancakes for the entree.
        /// </summary>
        /// <param name="pancake">bool for pancake</param>
        private bool pancake = true;

        /// <summary>
        ///     Gets/sets the sausage for the entree.
        /// </summary>
        /// <param name="sausageLink">bool for the sausage</param>
        private bool sausageLink = true;

        /// <summary>
        ///     Gets the price of the entree.
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        ///     Gets the calories of the entree.
        /// </summary>
        public override uint Calories => 602;

        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                sausageLink = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("SausageLink");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

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

        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                hashBrowns = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Hashbrowns");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        public bool Pancake
        {
            get => pancake;
            set
            {
                pancake = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Pancake");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        ///     Gets/sets the instructions for the entree
        /// </summary>
        /// <param name="instructions">the instructions for the burger</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hashbrowns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        ///     ToString override for the entree
        /// </summary>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}