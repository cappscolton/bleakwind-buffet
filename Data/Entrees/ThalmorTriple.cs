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
    public class ThalmorTriple
    {

        /* Private variable declaration for thalmor triple */
        private bool bun = true;
        private bool ketchup = true;
        private bool pickle = true;
        private bool mustard = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;

        /// <summary>
        /// If the entree comes with bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        /// <summary>
        /// If the entree comes with eggs
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// If the entree comes with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// If the entree comes with lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        /// <summary>
        /// If the entree comes with bacon
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// If the entree comes with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// If the entree comes with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// If the entree comes with a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// If the entree comes with a pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// If the entree comes with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// THe price of the vokun salad
        /// </summary>
        public double Price
        {
            get { return 8.32; }
        }

        /// <summary>
        /// The calories of the triple
        /// </summary>
        public uint Calories
        {
            get { return 943; }
        }

        /// <summary>
        /// A list of special instructions for preparing the thalmor triple
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!ketchup) instruc.Add("Hold ketchup");
                if (!bun) instruc.Add("Hold bun");
                if (!mustard) instruc.Add("Hold mustard");
                if (!cheese) instruc.Add("Hold cheese");
                if (!pickle) instruc.Add("Hold pickle");
                if (!tomato) instruc.Add("Hold tomato");
                if (!lettuce) instruc.Add("Hold lettuce");
                if (!mayo) instruc.Add("Hold mayo");
                if (!egg) instruc.Add("Hold egg");
                if (!bacon) instruc.Add("Hold bacon");
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
