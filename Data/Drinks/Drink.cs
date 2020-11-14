using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

/// <summary>
/// a base class representing the common properties of drinks
/// </summary>
namespace BleakwindBuffet.Data.Drinks
{
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        private Size s;

        /// <summary>
        ///     the size of the drink
        /// </summary>
        protected Size size = Size.Small;

        public abstract Size Size { get; set; }

        public string Name => ToString();

        /// <summary>
        ///     the price of the drink
        /// </summary>
        /// <value>in us dollars</value>
        public double Price { get; set; }

        /// <summary>
        ///     calories for the drink
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        ///     the special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// description for the drink
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        ///     Update event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Used to send update notification
        /// </summary>
        /// <param name="property"></param>
        protected void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}