/*
* Author: Colton Capps
* Class name: VokunSalad.cs
* Purpose: Represent a side item on the menu at Bleakwind
* A fruit salad
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing the vokun salad side item
    /// </summary>
    public class VokunSalad
    {
        /* Private variable declaration for waffle fries */
        private Size size = Size.Small;

        /// <summary>
        /// The calories of the fried miraak
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 41;
                    case Size.Medium:
                        return 52;
                    case Size.Large:
                        return 73;
                    default:
                        return 41;
                }
            }
        }

        /// <summary>
        /// THe price of the vokun salad
        /// </summary>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 0.93;
                    case Size.Medium:
                        return 1.28;
                    case Size.Large:
                        return 1.82;
                    default:
                        return 0.93;
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
        /// The size of the vokun salad
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

            return sz + "Vokun Salad";
        }
    }
}

