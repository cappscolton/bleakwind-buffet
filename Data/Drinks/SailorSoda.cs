﻿/*
* Author: Colton Capps
* Class name: SailorSoda.cs
* Purpose: Represent a drink on the menu at Bleakwind: Old-fashioned soda
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the sailor soda drink
    /// </summary>
    public class SailorSoda
    {
        /* Private variable declaration for sailor soda */
        private bool ice = true;
        private Size size = Size.Small;

        /// <summary>
        /// if the drink comes with ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// The calories of the soda
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (size)
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
        public double Price
        {
            get
            {
                switch (size)
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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!ice) instruc.Add("Hold ice");
                return instruc;
            }
        }
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        /// <summary>
        /// Returns a description of the soda
        /// </summary>
        /// <returns>A string describing the soda</returns>
        override public string ToString()
        {
            string sz;
            string flav;
            switch (size)
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
