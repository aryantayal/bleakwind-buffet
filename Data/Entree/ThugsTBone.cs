/*
 * Author: Aryan Tayal
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Entree
{
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// Gets the calories of the entree.
        /// </summary>
        public uint Calories => 982;



        /// <summary>
        /// Gets/sets the instructions for the entree 
        /// </summary>
        /// /// <param name="instructions">the instructions for the burger</param>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the entree 
        /// </summary>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}

