/*
 * Author: Aryan Tayal
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette
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
    public class GardenOrcOmelette : Entree
    {
        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the calories of the entree.
        /// </summary>
        public override uint Calories => 404;

        /// <summary>
        /// Gets/sets the broccoli for the entree. 
        /// </summary>
        /// <param name="broccoli">bool for broccoli</param>
        private bool broccoli = true;

        public bool Broccoli
        {
            get => broccoli;
            set
            {
                broccoli = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Broccoli");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets/sets the mushrooms for the entree. 
        /// </summary>
        /// <param name="mushrooms">mushroom bool</param>
        private bool mushrooms = true;

        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                mushrooms = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Mushrooms");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets/sets the hash browns for the entree. 
        /// </summary>
        /// <param name="tomato">bool for tomao</param>
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
        /// Gets/sets the cheddar for the entree. 
        /// </summary>
        /// <param name="cheddar">bool for cheddar</param>
        private bool cheddar = true;

        public bool Cheddar
        {
            get => cheddar;
            set
            {
                cheddar = value;
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Cheddar");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets/sets the instructions for the entree 
        /// </summary>
        /// <param name="instructions">the instructions for the burger</param>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// ToString override for the entree 
        /// </summary>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}