/*
* Author: Colton Capps
* Class name: MadOtarGrits.cs
* Purpose: Represent a side item on the menu at Bleakwind
* Cheesy Grits
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class MadOtarGrits
    {
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 105;
                    case Size.Medium:
                        return 142;
                    case Size.Large:
                        return 179;
                    default:
                        return 105;
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
                        return 1.22;
                    case Size.Medium:
                        return 1.58;
                    case Size.Large:
                        return 1.93;
                    default:
                        return 1.22;
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

            return sz + "Mad Otar Grits";
        }
    }
}
