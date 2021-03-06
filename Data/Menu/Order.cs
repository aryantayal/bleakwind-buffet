﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    /// <summary>
    ///     Representation of an order
    /// </summary>
    public class Order : INotifyPropertyChanged, ICollection, INotifyCollectionChanged
    {
        private static uint nextOrderNumber = 1;

        /// <summary>
        ///     order item
        /// </summary>
        public List<IOrderItem> order = new List<IOrderItem>();

        private readonly double salesTaxRate = 0.12;


        /// <summary>
        ///     Constructs a new instance of Order
        /// </summary>
        public Order()
        {
            //order = new List<IOrderItem>();
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        public uint Number { get; }

        public IEnumerable<IOrderItem> Items => order;

        /// <summary>
        ///     Cost of order before tax
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;

                foreach (var item in order) subtotal += item.Price;

                return subtotal;
            }
        }

        /// <summary>
        ///     Sales tax rate of the order
        /// </summary>
        public double Tax => salesTaxRate * Subtotal;

        /// <summary>
        ///     Total cost of the order
        /// </summary>
        public double TotalCost => Subtotal + Tax;

        public uint Calories { get; }

        public uint calorieSum
        {
            get
            {
                uint calSum = 0;
                foreach (var item in order) calSum += item.Calories;

                return calSum;
            }
        }

        public int Count => throw new NotImplementedException();
        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return order.GetEnumerator();
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        ///     PropertyChanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Notifies when property updates
        /// </summary>
        /// <param name="property">name of property</param>
        private void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private void ItemChanges(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                NotifyOfPropertyChanged("Subtotal");
                NotifyOfPropertyChanged("Tax");
                NotifyOfPropertyChanged("TotalCost");
            }

            if (e.PropertyName == "Calories") NotifyOfPropertyChanged("Calories");
        }

        /// <summary>
        ///     Adds a new item to the current order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            order.Add(item);
            CollectionChanged?.Invoke(this,
                new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Subtotal");
            NotifyOfPropertyChanged("Tax");
            NotifyOfPropertyChanged("TotalCost");
            item.PropertyChanged += ItemChanges;
        }

        /// <summary>
        ///     Removes an item from the current order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            CollectionChanged?.Invoke(this,
                new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, order.IndexOf(item)));
            order.Remove(item);
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Subtotal");
            NotifyOfPropertyChanged("Tax");
            NotifyOfPropertyChanged("TotalCost");
            item.PropertyChanged -= ItemChanges;
        }
    }
}