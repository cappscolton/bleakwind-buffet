/*
* Author: Colton Capps
* Class name: PhillyPoacher.cs
* Purpose: Represent an entree on the menu at Bleakwind: 
* Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the philly poacher entree
    /// </summary>
    public class PhillyPoacher
    {
        /* Private variable declaration for philly poacher */
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// THe price of the philly poacher
        /// </summary>
        public double Price
        {
            get { return 7.23; }
        }

        /// <summary>
        /// The calories of the poacher
        /// </summary>
        public uint Calories
        {
            get { return 784; }
        }

        /// <summary>
        /// if the entree comes with sirloin
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }

        /// <summary>
        /// if the entree comes with onion
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }

        /// <summary>
        /// if the entree comes with a roll
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        
        /// <summary>
         /// A list of special instructions for preparing the philly poacher
         /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!sirloin) instruc.Add("Hold sirloin");
                if (!onion) instruc.Add("Hold onion");
                if (!roll) instruc.Add("Hold roll");
                return instruc;
            }
        }
        
        /// <summary>
         /// Returns a description of the philly poacher
         /// </summary>
         /// <returns>A string describing the philly poacher</returns>
        override public string ToString()
        {
            return "Philly Poacher";
        }
    }
}
