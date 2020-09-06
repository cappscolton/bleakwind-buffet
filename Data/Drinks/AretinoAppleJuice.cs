/*
* Author: Colton Capps
* Class name: AretinoAppleJuice.cs
* Purpose: Represent a drink on the menu at Bleakwind: Apple juice
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{

    /// <summary>
    /// Class representing the aretino apple juice drink
    /// </summary>
    public class AretinoAppleJuice
    {
        /* Private variable declaration for aretino applejuice */
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
        /// The calories of the apple juice
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 44;
                    case Size.Medium:
                        return 88;
                    case Size.Large:
                        return 132;
                    default:
                        return 44;
                }
            }
        }

        /// <summary>
        /// THe price of the apple juice
        /// </summary>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 0.62;
                    case Size.Medium:
                        return 0.87;
                    case Size.Large:
                        return 1.01;
                    default:
                        return 0.62;
                }
            }
        }

        /// <summary>
        /// A list of special instructions for preparing the apple juice
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
        /// Returns a description of the apple juice
        /// </summary>
        /// <returns>A string describing the apple juice</returns>
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
            
            return sz + "Aretino Apple Juice";
        }
    }
}
