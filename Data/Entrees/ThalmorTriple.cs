/*
* Author: Colton Capps
* Class name: ThalmorTriple.cs
* Purpose: Represent an entree on the menu at Bleakwind 
* Inlcudes two 1/4lb patties with a 1/2lb patty 
* inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the thalmor triple side item
    /// </summary>
    public class ThalmorTriple : Entree
    {
        /// <summary>
        /// If the entree comes with bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// If the entree comes with eggs
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// If the entree comes with tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// If the entree comes with lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If the entree comes with bacon
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// If the entree comes with ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If the entree comes with cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// If the entree comes with a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If the entree comes with a pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If the entree comes with mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// THe price of the vokun salad
        /// </summary>
        public override double Price
        {
            get { return 8.32; }
        }

        /// <summary>
        /// The calories of the triple
        /// </summary>
        public override uint Calories
        {
            get { return 943; }
        }

        /// <summary>
        /// A list of special instructions for preparing the thalmor triple
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
                if (!Egg) instruc.Add("Hold egg");
                if (!Bacon) instruc.Add("Hold bacon");
                return instruc;
            }
        }

        /// <summary>
        /// Returns a description of the thalmor triple
        /// </summary>
        /// <returns>A string describing the thalmor triple</returns>
        override public string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
