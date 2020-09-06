/*
* Author: Colton Capps
* Class name: FriedMiraak.cs
* Purpose: Represent an entree on the menu at Bleakwind
* Hash brown pancakes
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing the fried miraak side item
    /// </summary>
    public class FriedMiraak
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
                        return 151;
                    case Size.Medium:
                        return 236;
                    case Size.Large:
                        return 306;
                    default:
                        return 151;
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
                        return 1.78;
                    case Size.Medium:
                        return 2.01;
                    case Size.Large:
                        return 2.88;
                    default:
                        return 1.78;
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
        /// The sie of the miraak side
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

            return sz + "Fried Miraak";
        }
    }
}
