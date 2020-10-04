/*
* Author: Colton Capps
* Class name: SailorSoda.cs
* Purpose: Represent a drink on the menu at Bleakwind: Old-fashioned soda
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the sailor soda drink
    /// </summary>
    public class SailorSoda : Drink
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
        private bool ice = true;
        /// <summary>
        /// if the drink comes with ice, notifies for property changes to ice and special instructions
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 117;
                    case Size.Medium:
                        return 153;
                    case Size.Large:
                        return 205;
                    default:
                        return 117;
                }
            }
        }

        /// <summary>
        /// THe price of the soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.42;
                    case Size.Medium:
                        return 1.74;
                    case Size.Large:
                        return 2.07;
                    default:
                        return 1.42;
                }
            }
        }

        /// <summary>
        /// A list of special instructions for preparing the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!Ice) instruc.Add("Hold ice");
                return instruc;
            }
        }

        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// Returns a description of the soda
        /// </summary>
        /// <returns>A string describing the soda</returns>
        override public string ToString()
        {
            string sz;
            string flav;
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
            switch (flavor)
            {
                case SodaFlavor.Blackberry:
                    flav = "Blackberry ";
                    break;
                case SodaFlavor.Cherry:
                    flav = "Cherry ";
                    break;
                case SodaFlavor.Grapefruit:
                    flav = "Grapefruit ";
                    break;
                case SodaFlavor.Lemon:
                    flav = "Lemon ";
                    break;
                case SodaFlavor.Peach:
                    flav = "Peach ";
                    break;
                case SodaFlavor.Watermelon:
                    flav = "Watermelon ";
                    break;
                default:
                    flav = "Blackberry ";
                    break;
            }
            return sz + flav + "Sailor Soda";
        }
    }
}
