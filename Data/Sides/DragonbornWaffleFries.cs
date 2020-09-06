/*
* Author: Colton Capps
* Class name: DragonbornWaffleFries.cs
* Purpose: Represent an entree on the menu at Bleakwind
* Cajun fries
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing waffle fry side
    /// </summary>
    public class DragonbornWaffleFries
    {
        /* Private variable declaration for waffle fries */
        private Size size = Size.Small;

        /// <summary>
        /// The calories of the waffle fries
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 77;
                    case Size.Medium:
                        return 89;
                    case Size.Large:
                        return 100;
                    default:
                        return 77;
                }
            }
        }

        /// <summary>
        /// The price of the waffe fries
        /// </summary>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 0.42;
                    case Size.Medium:
                        return 0.76;
                    case Size.Large:
                        return 0.96;
                    default:
                        return 0.42;
                }
            }
        }

        /// <summary>
        /// A list of special instructions for preparing the waffle fries
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// THe size of the waffle fries
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Returns a description of the waffle fries
        /// </summary>
        /// <returns>A string describing the waffle fries</returns>
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

            return sz + "Dragonborn Waffle Fries";
        }
    }
}
