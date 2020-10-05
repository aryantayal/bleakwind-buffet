/*
 * Author: Aryan Tayal
 * Class name: BrianheartBurger.cs
 * Purpose: Class used to represent the Brian heart Burger
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
    public class BriarheartBurger : Entree , INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Gets the price for the burger
        /// </summary>
        public override double Price => 6.32;
        /// <summary>
        /// gets the calories for the burger
        /// </summary>
        public override uint Calories => 732;

        private bool ketchup = true;
        /// <summary>
        /// get/set for ketchup
        /// </summary>
        /// <param name="ketchup">ketchup</param>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
                NotifyOfPropertyChanged("Ketchup");
                NotifyOfPropertyChanged("SpecialInstructions");

            }
        }
        private bool bun = true;
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;

            }
        } 

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
                NotifyOfPropertyChanged("Mustard");
                NotifyOfPropertyChanged("SpecialInstructions");
                mustard = value; 

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

            set {
                NotifyOfPropertyChanged("Pickle");
                NotifyOfPropertyChanged("SpecialInstructions");
                pickle = value; }
        }
        /// <summary>
        /// get/set for cheese
        /// </summary>
        /// <param name="cheese">bool for the cheese on the burger</param>
        private bool cheese = true;
        public bool Cheese
        {
            get => cheese;

            set {
                NotifyOfPropertyChanged("Cheese");
                NotifyOfPropertyChanged("SpecialInstructions");
                cheese = value; }
        }

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// the get set for the instructions
        /// </summary>
        /// <param name="instructions">the instructions for the burger</param>
        public override List<string> SpecialInstructions
        {
            get {

                List<string> instructions = new List<string>(specialInstructions);
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                NotifyOfPropertyChanged("SpecialInstructions");
                return instructions;
            }
        }
        /// <summary>
        /// to string method
        /// </summary>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }
}
