/*
* Author: Colton Capps
* Class name: MarkarthMilk.cs
* Purpose: Represent a drink on the menu at Bleakwind: 2% milk
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the markarth milk drink
    /// </summary>
    public class MarkarthMilk
    {
        /* Private variable declaration for markarth milk*/
        private bool ice = false;
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
        /// The calories of the milk
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 56;
                    case Size.Medium:
                        return 72;
                    case Size.Large:
                        return 93;
                    default:
                        return 56;
                }
            }
        }

        /// <summary>
        /// THe price of the milk
        /// </summary>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 1.05;
                    case Size.Medium:
                        return 1.11;
                    case Size.Large:
                        return 1.22;
                    default:
                        return 1.05;
                }
            }
        }

        /// <summary>
        /// A list of special instructions for preparing the milk
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (ice) instruc.Add("Add ice");
                return instruc;
            }
        }
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        /// <summary>
        /// Returns a description of the milk
        /// </summary>
        /// <returns>A string describing the milk</returns>
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

            return sz + "Markarth Milk";
        }
    }
}
