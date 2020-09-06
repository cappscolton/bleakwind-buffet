/*
* Author: Colton Capps
* Class name: ThugsTBone.cs
* Purpose: Represent an entree on the menu at Bleakwind 
* Juicy T-Bone not much else to say
*/



using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the thugs t-bone entree
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// THe price of the vokun salad
        /// </summary>
        public double Price
        {
            get { return 6.44; }
        }

        /// <summary>
        /// The calories of the t-bone
        /// </summary>
        public uint Calories
        {
            get { return 982; }
        }
        /// <summary>
        /// A list of special instructions for preparing the t-bone
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }
        /// <summary>
         /// Returns a description of the t-bone
         /// </summary>
         /// <returns>A string describing the t-bone</returns>
        override public string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
