/*
* Author: Colton Capps
* Class name: FriedMiraak.cs
* Purpose: Represent an entree on the menu at Bleakwind
* Hash brown pancakes
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class FriedMiraak
    {
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 151;
                    case Size.Medium:
                        return 263;
                    case Size.Large:
                        return 306;
                    default:
                        return 151;
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
                        return 1.78;
                    case Size.Medium:
                        return 2.01;
                    case Size.Large:
                        return 2.88;
                    default:
                        return 1.78;
                }
            }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        override public string ToString()
        {
            string sz;
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

            return sz + "Fried Miraak";
        }
    }
}
