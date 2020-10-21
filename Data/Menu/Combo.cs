using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem
    {
        /// <summary>
        /// Event handler for property updates
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies when property updates
        /// </summary>
        /// <param name="property">name of property</param>
        private void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private Entree.Entree entree;

        public Combo()
        {
        }

        /// <summary>
        /// An Entree item in the combo
        /// </summary>
        public Entree.Entree Entree
        {
            get => entree;
            set
            {
                entree = value;
                NotifyOfPropertyChanged("Entree");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private Drink drink;

        /// <summary>
        /// A Drink item in the combo
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                drink = value;
                NotifyOfPropertyChanged("Drink");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        private Side side;

        /// <summary>
        /// A side item in the combo
        /// </summary>
        public Side Side
        {
            get => side;
            set
            {
                side = value;
                NotifyOfPropertyChanged("Side");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// The calories of the combo items
        /// </summary>
        public uint Calories
        {
            get
            {
                uint cal = 0;
                if (Entree != null) cal += Entree.Calories;

                if (Drink != null) cal += Drink.Calories;

                if (Side != null) cal += Side.Calories;

                return cal;
            }
        }

        /// <summary>
        /// The price of the combo items
        /// </summary>
        public double Price
        {
            get
            {
                var price = 0.0;
                if (Entree != null) price += Entree.Price;

                if (Drink != null) price += Drink.Price;

                if (Side != null) price += Side.Price;

                return price - 1.0;
            }
        }

        /// <summary>
        /// The items and their special instructions that are in the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var si = new List<string>();
                si.Add(Entree.ToString());
                si.AddRange(Entree.SpecialInstructions);
                si.Add(Side.ToString());
                si.AddRange(Side.SpecialInstructions);
                si.Add(Drink.ToString());
                si.AddRange(Drink.SpecialInstructions);
                return si;
            }
        }
    }
}