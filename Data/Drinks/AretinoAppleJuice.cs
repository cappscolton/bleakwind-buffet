/*
* Author: Colton Capps
* Class name: AretinoAppleJuice.cs
* Purpose: Represent a drink on the menu at Bleakwind: Apple juice
*/

using System.Collections.Generic;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{

    /// <summary>
    /// Class representing the aretino apple juice drink
    /// </summary>
    public class AretinoAppleJuice : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// event for implementing PropertyChange notifications
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
            }
        }

        /// <summary>
        /// private backing variable for ice
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// if the drink comes with ice, notifies for property changes to ice and special instructions
        /// </summary>
        public bool Ice { 
            get => ice;
            set { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The calories of the apple juice
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 44;
                    case Size.Medium:
                        return 88;
                    case Size.Large:
                        return 132;
                    default:
                        return 44;
                }
            }
        }

        /// <summary>
        /// THe price of the apple juice
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.62;
                    case Size.Medium:
                        return 0.87;
                    case Size.Large:
                        return 1.01;
                    default:
                        return 0.62;
                }
            }
        }

        /// <summary>
        /// A list of special instructions for preparing the apple juice
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
        /// Returns a description of the apple juice
        /// </summary>
        /// <returns>A string describing the apple juice</returns>
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
            
            return sz + "Aretino Apple Juice";
        }
    }
}
