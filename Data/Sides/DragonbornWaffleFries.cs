/*
* Author: Colton Capps
* Class name: DragonbornWaffleFries.cs
* Purpose: Represent an entree on the menu at Bleakwind
* Cajun fries
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing waffle fry side
    /// </summary>
    public class DragonbornWaffleFries : Side, INotifyPropertyChanged
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <summary>
        /// The calories of the waffle fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 77;
                    case Size.Medium:
                        return 89;
                    case Size.Large:
                        return 100;
                    default:
                        return 77;
                }
            }
        }

        /// <summary>
        /// The price of the waffe fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.42;
                    case Size.Medium:
                        return 0.76;
                    case Size.Large:
                        return 0.96;
                    default:
                        return 0.42;
                }
            }
        }

        /// <summary>
        /// A list of special instructions for preparing the waffle fries
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// Returns a description of the waffle fries
        /// </summary>
        /// <returns>A string describing the waffle fries</returns>
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

            return sz + "Dragonborn Waffle Fries";
        }
    }
}
