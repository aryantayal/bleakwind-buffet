using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entree
{
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public string Name => ToString();

        /// <summary>
        ///     the price of the entree
        /// </summary>
        /// <value>in us dollars</value>
        public abstract double Price { get; }

        /// <summary>
        ///     calories for the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        ///     the special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        /// <summary>
        /// description for the entree
        /// </summary>
        public abstract string Description { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}