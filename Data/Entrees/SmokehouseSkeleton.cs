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
    public class SmokehouseSkeleton : Entree
    {

        /// <summary>
        /// THe price of the smokehouse skeleton
        /// </summary>
        public override double Price 
        {
            get { return 5.62; }
        }

        /// <summary>
        /// The calories of the triple
        /// </summary>
        public override uint Calories
        {
            get { return 602; }
        }

        /// <summary>
        ///  if the entree comes with pancakes
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        ///  if the entree comes with eggs
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        ///  if the entree comes with sausage
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        ///  if the entree comes with hash browns
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// A list of special instructions for preparing the skeleton
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!HashBrowns) instruc.Add("Hold hash browns");
                if (!SausageLink) instruc.Add("Hold sausage");
                if (!Egg) instruc.Add("Hold eggs");
                if (!Pancake) instruc.Add("Hold pancakes");
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
