using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem
    {
        private Drink drink = new WarriorWater();
        private Entree.Entree entree = new DoubleDraugr();
        private Side side = new VokunSalad();


        public Combo()
        {
            entree.PropertyChanged += ItemChangeListener;
            drink.PropertyChanged += ItemChangeListener;
            side.PropertyChanged += ItemChangeListener;
        }

        /// <summary>
        ///     An Entree item in the combo
        /// </summary>
        public Entree.Entree Entree
        {
            get => entree;
            set
            {
                entree.PropertyChanged -= ItemChangeListener;
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ComboEntree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                entree.PropertyChanged += ItemChangeListener;
            }
        }


        /// <summary>
        ///     A Drink item in the combo
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                drink.PropertyChanged -= ItemChangeListener;
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ComboDrink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                drink.PropertyChanged += ItemChangeListener;
            }
        }


        /// <summary>
        ///     A side item in the combo
        /// </summary>
        public Side Side
        {
            get => side;
            set
            {
                side.PropertyChanged -= ItemChangeListener;
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ComboSide"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                side.PropertyChanged += ItemChangeListener;
            }
        }

        /// <summary>
        ///     Event handler for property updates
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     The calories of the combo items
        /// </summary>
        public uint Calories => drink.Calories + entree.Calories + side.Calories;

        /// <summary>
        ///     The price of the combo items
        /// </summary>
        public double Price => drink.Price + entree.Price + side.Price - 1;

        /// <summary>
        ///     The items and their special instructions that are in the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                instructions.Add(entree.ToString());
                instructions.AddRange(entree.SpecialInstructions);

                instructions.Add(drink.ToString());
                instructions.AddRange(drink.SpecialInstructions);

                instructions.Add(side.ToString());

                return instructions;
            }
        }


        /// <summary>
        ///     Notifies when property updates
        /// </summary>
        /// <param name="property">name of property</param>
        private void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public void ItemChangeListener(object sender, PropertyChangedEventArgs e)
        {
            //Size, flavor, special instructions
            if (e.PropertyName == "Size")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
            else if (e.PropertyName == "Flavor")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
            else if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            else
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
    }
}