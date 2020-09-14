/*
* Author: Colton Capps
* Class name: DoubleDraugr.cs
* Purpose: Represent an entree on the menu at Bleakwind: 
* Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the double draugr entree
    /// </summary>
    public class DoubleDraugr : Entree
    {
        /// <summary>
        /// if the entree comes with tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// if the entree comes with lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// if the entree comes with tomato
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// if the entree comes with ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// if the entree comes with cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// if the entree comes with a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// if the entree comes with pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// if the entree comes with mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// THe price of the entree
        /// </summary>
        public override double Price
        {
            get { return 7.32; }
        }

        /// <summary>
        /// The calories of the draugr
        /// </summary>
        public override uint Calories
        {
            get { return 843; }
        }
        
        /// <summary>
         /// A list of special instructions for preparing the double draugr
         /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!Ketchup) instruc.Add("Hold ketchup");
                if (!Bun) instruc.Add("Hold bun");
                if (!Mustard) instruc.Add("Hold mustard");
                if (!Cheese) instruc.Add("Hold cheese");
                if (!Pickle) instruc.Add("Hold pickle");
                if (!Tomato) instruc.Add("Hold tomato");
                if (!Lettuce) instruc.Add("Hold lettuce");
                if (!Mayo) instruc.Add("Hold mayo");
                return instruc;
            }
        }
       
        /// <summary>
        /// Returns a description of the double draugr
        /// </summary>
        /// <returns>A string describing the double draugr</returns>
        override public string ToString()
        {
            return "Double Draugr";
        }
    }
}
