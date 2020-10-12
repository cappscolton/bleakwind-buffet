/*
* Author: Colton Capps
* Class name: CandlehearthCoffee.cs
* Purpose: Represent a drink on the menu at Bleakwind: Coffee
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the candlehearh coffee drink
    /// </summary>
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// event for implementing PropertyChange notifications
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// size of the drink, invokes PropertyChanged event on size, price, and calories
        /// </summary>
        public override Size Size
        {
            get => base.Size;
            set
            {
                base.Size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

            }
        }

        /// <summary>
        /// private backing variable for ice
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// if the drink comes with ice, notifies for property changes to ice and special instructions
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// private backing variable for decaf
        /// </summary>
        private bool decaf = false;
        /// <summary>
        /// if the drink comes with decaf, notifies for property changes to decaf and special instructions
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// private backing variable for cream
        /// </summary>
        private bool cream = false;
        /// <summary>
        /// if the drink comes with crean, notifies for property changes to cream and special instructions
        /// </summary>
        public bool RoomForCream
        {
            get => cream;
            set
            {
                cream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 7;
                    case Size.Medium:
                        return 10;
                    case Size.Large:
                        return 20;
                    default:
                        return 7;
                }
            }
        }

        /// <summary>
        /// THe price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.75;
                    case Size.Medium:
                        return 1.25;
                    case Size.Large:
                        return 1.75;
                    default:
                        return 0.75;
                }
            }
        }

        /// <summary>
        /// A list of special instructions for preparing the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (Ice) instruc.Add("Add ice");
                if (RoomForCream) instruc.Add("Add cream");
                return instruc;
            }
        }
        /// <summary>
        /// Returns a description of the coffee
        /// </summary>
        /// <returns>A string describing the coffee</returns>
        override public string ToString()
        {
            string sz;
            switch (Size)
            {
                case Size.Small:
                    sz = "Small ";
                    break;
                case Size.Medium:
                    sz = "Medium ";
                    break;
                case Size.Large:
                    sz = "Large ";
                    break;
                default:
                    sz = "Small ";
                    break;
            }
            if (Decaf) return sz + "Decaf Candlehearth Coffee";
            return sz + "Candlehearth Coffee";
        }
    }
}

