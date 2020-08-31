/*
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
    class SailorSoda
    {
        private bool ice = true;

        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!ice) instruc.Add("Hold ice");
                return instruc;
            }
        }
        private Size size = Size.Small;
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
