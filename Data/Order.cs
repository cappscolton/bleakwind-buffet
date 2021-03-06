﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem>, INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor. Increments the overall order number and assigns our listener to the CollectionChanged property
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;
        }

        /// <summary>
        /// Static value for the order number of this order. Doesn't reset until program ends
        /// </summary>
        public static uint nextOrderNumber { get; set; } = 0;

        /// <summary>
        /// Listener that objects added to the collection must subscribe to. This allows us to get notifications
        /// when Price and Calories properties of items in the collection change and reflect that in the Order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PropertyChangeListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            }
            else if(e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Listener that makes sure the subtotal, tax, total, and calorie properties are updated when objects are added or removed from the collection
        /// Subscribe to this in the constructor. Also adds listener to properties in the item added so that when its properties update, so does the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (IOrderItem i in e.NewItems)
                    i.PropertyChanged += PropertyChangeListener;
            }
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (IOrderItem i in e.OldItems)
                    i.PropertyChanged -= PropertyChangeListener;
            }

        }

        /// <summary>
        /// Property for tax rate default 12%
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;
        /// <summary>
        /// Property for subtotal cost of the order, calculated by adding up Price property of each IOrderItem in the collection
        /// </summary>
        public double Subtotal {
            get
            {
                double total = 0.0;
                foreach (IOrderItem i in Items)
                {
                    total += i.Price;
                }
                return total;
            }
        }
        /// <summary>
        /// Property for Tax on the order.
        /// </summary>
        public double Tax
        {
            get
            {
                return Subtotal * SalesTaxRate;
            }
        }
        /// <summary>
        /// Property for Total cost of the order. Subtotal - tax.
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal - Tax;
            }
        }
        /// <summary>
        /// Total calories of the order, adding up all the Calorie properties from items in the collection
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach (IOrderItem i in Items)
                {
                    calories += i.Calories;
                }
                return calories;
            }
        }
        /// <summary>
        /// The number of this order. Displayed on the GUI.
        /// </summary>
        public uint Number { get; }

    }
}
