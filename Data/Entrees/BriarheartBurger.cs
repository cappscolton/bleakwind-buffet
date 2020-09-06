/*
* Author: Colton Capps
* Class name: BriarheartBurger.cs
* Purpose: Represent an entree on the menu at Bleakwind
* Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the briarheart burger entree
    /// </summary>
    public class BriarheartBurger
    {
        /* Private variable declaration for briarheart burger */
        private bool bun = true;
        private bool ketchup = true;
        private bool pickle = true;
        private bool mustard = true;
        private bool cheese = true;

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
        /// if the entree comes with pickle
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// if the entree comes with ketchup
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
        /// THe price of the burger
        /// </summary>
        public double Price
        {
            get { return 6.32; }
        }

        /// <summary>
        /// The calories of the briarheart burger
        /// </summary>
        public uint Calories
        {
            get { return 743; }
        }
        
        /// <summary>
         /// A list of special instructions for preparing the briarheart burger
         /// </summary>
        public List<string> SpecialInstructions
        {
            get {
                List<string> instruc = new List<string>();
                if (!ketchup) instruc.Add("Hold ketchup");
                if (!bun) instruc.Add("Hold bun");
                if (!mustard) instruc.Add("Hold mustard");
                if (!cheese) instruc.Add("Hold cheese");
                if (!pickle) instruc.Add("Hold pickle");
                return instruc;
            }
        }

        /// <summary>
        /// Returns a description of the briarheart burger
        /// </summary>
        /// <returns>A string describing the briarheart burger</returns>
        override public string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
