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
    public class CandlehearthCoffee : Drink
    {

        /// <summary>
        /// if the drink comes with ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// if the drink is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// if the drink comes with cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// The calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
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
        public override double Price
        {
            get
            {
                switch (Size)
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
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (Ice) instruc.Add("Add ice");
                if (RoomForCream) instruc.Add("Add cream");
                return instruc;
            }
        }
        /// <summary>
        /// Returns a description of the coffee
        /// </summary>
        /// <returns>A string describing the coffee</returns>
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
            if (Decaf) return sz + "Decaf Candlehearth Coffee";
            return sz + "Candlehearth Coffee";
        }
    }
}

