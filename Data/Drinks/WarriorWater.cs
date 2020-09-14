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
    /// <summary>
    /// Class representing the warrior water drink
    /// </summary>
    public class WarriorWater : Drink
    {
        /// <summary>
        /// if the drink comes with ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// if the drink comes with lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The calories of the water
        /// </summary>
        public override uint Calories
        {
            get { return 0; }
        }

        /// <summary>
        /// THe price of the water
        /// </summary>
        public override double Price
        {
            get { return 0.0; }
        }

        /// <summary>
        /// A list of special instructions for preparing the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!Ice) instruc.Add("Hold ice");
                if (Lemon) instruc.Add("Add lemon");
                return instruc;
            }
        }
        /// <summary>
        /// Returns a description of the water
        /// </summary>
        /// <returns>A string describing the water</returns>
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

            return sz + "Warrior Water";
        }
    }
}
