using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// the size of the side
        /// </summary>
        protected void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private Size s;

        /// <summary>
        /// the size of the side
        /// </summary>
        protected Size size = Size.Small;

        public abstract Size Size { get; set; }


        public string Name
        {
            get => ToString();
        }
        /// <summary>
        /// the price of the side
        /// </summary>
        /// <value>in us dollars</value>
        public double Price { get; set; }

        /// <summary>
        /// calories for the side
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// the special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}