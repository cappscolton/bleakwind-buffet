/*
* Author: Colton Capps
* Class name: SmokehouseSkeleton.cs
* Purpose: Represent an entree on the menu at Bleakwind: 
* Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the smokehouse skeleton entree
    /// </summary>
    public class SmokehouseSkeleton
    {

        /* Private variable declaration for skeleton */
        private bool hashBrowns = true;
        private bool pancake = true;
        private bool sausageLink = true;
        private bool egg = true;

        /// <summary>
        /// THe price of the smokehouse skeleton
        /// </summary>
        public double Price 
        {
            get { return 5.62; }
        }

        /// <summary>
        /// The calories of the triple
        /// </summary>
        public uint Calories
        {
            get { return 602; }
        }

        /// <summary>
        ///  if the entree comes with pancakes
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        /// <summary>
        ///  if the entree comes with eggs
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        ///  if the entree comes with sausage
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }

        /// <summary>
        ///  if the entree comes with hash browns
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set { hashBrowns = value; }
        }
        
        /// <summary>
         /// A list of special instructions for preparing the skeleton
         /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!hashBrowns) instruc.Add("Hold hash browns");
                if (!sausageLink) instruc.Add("Hold sausage");
                if (!egg) instruc.Add("Hold eggs");
                if (!pancake) instruc.Add("Hold pancakes");
                return instruc;
            }
        }/// <summary>
         /// Returns a description of the skeleton
         /// </summary>
         /// <returns>A string describing the skeleton</returns>
        override public string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
