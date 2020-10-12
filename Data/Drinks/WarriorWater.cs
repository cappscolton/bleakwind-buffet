/*
* Author: Colton Capps
* Class name: WarriorWater.cs
* Purpose: Represent a drink on the menu at Bleakwind: Water
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the warrior water drink
    /// </summary>
    public class WarriorWater : Drink, INotifyPropertyChanged
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <summary>
        /// private backing variable for ice
        /// </summary>
        private bool ice = true;
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
        /// private backing variable for lemon
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// if the drink comes with lemon, notifies for property changes to ice and special instructions
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The calories of the water
        /// </summary>
        public override uint Calories
        {
            get { return 0; }
        }

        /// <summary>
        /// THe price of the water
        /// </summary>
        public override double Price
        {
            get { return 0.0; }
        }

        /// <summary>
        /// A list of special instructions for preparing the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!Ice) instruc.Add("Hold ice");
                if (Lemon) instruc.Add("Add lemon");
                return instruc;
            }
        }
        /// <summary>
        /// Returns a description of the water
        /// </summary>
        /// <returns>A string describing the water</returns>
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

            return sz + "Warrior Water";
        }
    }
}
