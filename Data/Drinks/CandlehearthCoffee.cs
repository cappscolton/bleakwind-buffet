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
    /// <summary>
    /// Class representing the candlehearh coffee drink
    /// </summary>
    public class CandlehearthCoffee
    {
        /* Private variable declaration for candlehearth coffee*/
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;
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
        /// if the drink is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// if the drink comes with cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        /// <summary>
        /// The calories of the coffee
        /// </summary>
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

        /// <summary>
        /// THe price of the coffee
        /// </summary>
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

        /// <summary>
        /// A list of special instructions for preparing the coffee
        /// </summary>
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
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        /// <summary>
        /// Returns a description of the coffee
        /// </summary>
        /// <returns>A string describing the coffee</returns>
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
            if (Decaf) return sz + "Decaf Candlehearth Coffee";
            return sz + "Candlehearth Coffee";
        }
    }
}

