/*
 * Author: Aryan Tayal
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone
 */

using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entree
{
    public class ThugsTBone : Entree
    {
        /// <summary>
        ///     Gets the price of the entree.
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        ///     Gets the calories of the entree.
        /// </summary>
        public override uint Calories => 982;


        /// <summary>
        ///     Gets/sets the instructions for the entree
        /// </summary>
        /// ///
        /// <param name="instructions">the instructions for the burger</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                NotifyOfPropertyChanged("Name");
                var instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Description for the entree
        /// </summary>
        public override string Description => "Juicy T-Bone, not much else to say.";

        /// <summary>
        ///     ToString override for the entree
        /// </summary>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}