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
    public class PhillyPoacher : Entree
    {
        /// <summary>
        /// THe price of the philly poacher
        /// </summary>
        public override double Price
        {
            get { return 7.23; }
        }

        /// <summary>
        /// The calories of the poacher
        /// </summary>
        public override uint Calories
        {
            get { return 784; }
        }

        /// <summary>
        /// if the entree comes with sirloin
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// if the entree comes with onion
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// if the entree comes with a roll
        /// </summary>
        public bool Roll { get; set; } = true;
        /// <summary>
        /// A list of special instructions for preparing the philly poacher
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!Sirloin) instruc.Add("Hold sirloin");
                if (!Onion) instruc.Add("Hold onion");
                if (!Roll) instruc.Add("Hold roll");
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
