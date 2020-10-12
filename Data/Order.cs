using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem>
    {
        public Order()
        {
            Number = nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;
        }

        public static uint nextOrderNumber { get; set; } = 0;

        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
        }

        public double SalesTaxRate { get; set; } = 0.12;

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

        public double Tax
        {
            get
            {
                return Subtotal * SalesTaxRate;
            }
        }

        public double Total
        {
            get
            {
                return Subtotal - Tax;
            }
        }

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

        public uint Number { get; }

    }
}
