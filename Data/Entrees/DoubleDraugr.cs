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
    public class DoubleDraugr
    {
        /* Private variable declaration for double draugr */
        private bool bun = true;
        private bool ketchup = true;
        private bool pickle = true;
        private bool mustard = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;

        /// <summary>
        /// if the entree comes with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// if the entree comes with lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        /// <summary>
        /// if the entree comes with tomato
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// if the entree comes with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// if the entree comes with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// if the entree comes with a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// if the entree comes with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// if the entree comes with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
         /// THe price of the entree
         /// </summary>
        public double Price
        {
            get { return 7.32; }
        }

        /// <summary>
        /// The calories of the draugr
        /// </summary>
        public uint Calories
        {
            get { return 843; }
        }
        
        /// <summary>
         /// A list of special instructions for preparing the double draugr
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
