/*
 * Author: Aryan Tayal
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Entree
{
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the calories of the entree.
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Gets/sets the sausage for the entree. 
        /// </summary>
        /// <param name="sausageLink">bool for the sausage</param>
        private bool sausageLink = true;
        public bool SausageLink
        {
            get => sausageLink;
            set => sausageLink = value;
        }

        /// <summary>
        /// Gets/sets the eggs for the entree. 
        /// </summary>
        /// <param name="egg">bool for egg</param>
        private bool egg = true;
        public bool Egg
        {
            get => egg;
            set => egg = value;
        }

        /// <summary>
        /// Gets/sets the hash browns for the entree. 
        /// </summary>
        /// <param name="hashbrown">bool for hashbrown</param>
        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get => hashBrowns;
            set => hashBrowns = value;
        }

        /// <summary>
        /// Gets/sets the pancakes for the entree. 
        /// </summary>
        /// <param name="pancake">bool for pancake</param>
        private bool pancake = true;
        public bool Pancake
        {
            get => pancake;
            set => pancake = value;
        }

        /// <summary>
        /// Gets/sets the instructions for the entree 
        /// </summary>
        /// <param name="instructions">the instructions for the burger</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the entree 
        /// </summary>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
