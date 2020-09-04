/*
* Author: Colton Capps
* Class name: WarriorWater.cs
* Purpose: Represent a drink on the menu at Bleakwind: Water
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        private Size size = Size.Small;
        private bool ice = true;
        private bool lemon = false;

        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        public uint Calories
        {
            get { return 0; }
        }
        public double Price
        {
            get { return 0.0; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!ice) instruc.Add("Hold ice");
                if (lemon) instruc.Add("Add lemon");
                return instruc;
            }
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

            return sz + "Warrior Water";
        }
    }
}
