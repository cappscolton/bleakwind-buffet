/*
* Author: Colton Capps
* Class name: CandlehearthCoffee.cs
* Purpose: Represent a drink on the menu at Bleakwind: Coffee
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class CandlehearthCoffee
    {
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;

        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        public uint Calories
        {
            get
            {
                switch (size)
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
        public double Price
        {
            get
            {
                switch (size)
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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (ice) instruc.Add("Add ice");
                if (roomForCream) instruc.Add("Add cream");
                return instruc;
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

            return sz + "Candlehearth Coffee";
        }
    }
}

