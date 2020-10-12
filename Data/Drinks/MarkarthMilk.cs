/*
* Author: Colton Capps
* Class name: MarkarthMilk.cs
* Purpose: Represent a drink on the menu at Bleakwind: 2% milk
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    

    
    /// <summary>
    /// Class representing the markarth milk drink
    /// </summary>
    public class MarkarthMilk : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// event for implementing PropertyChange notifications
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// size of the drink, invokes PropertyChanged event
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
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
        /// The calories of the milk
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 56;
                    case Size.Medium:
                        return 72;
                    case Size.Large:
                        return 93;
                    default:
                        return 56;
                }
            }
        }

        /// <summary>
        /// THe price of the milk
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.05;
                    case Size.Medium:
                        return 1.11;
                    case Size.Large:
                        return 1.22;
                    default:
                        return 1.05;
                }
            }
        }

        /// <summary>
        /// A list of special instructions for preparing the milk
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (Ice) instruc.Add("Add ice");
                return instruc;
            }
        }
        /// <summary>
        /// Returns a description of the milk
        /// </summary>
        /// <returns>A string describing the milk</returns>
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

            return sz + "Markarth Milk";
        }
    }
}
