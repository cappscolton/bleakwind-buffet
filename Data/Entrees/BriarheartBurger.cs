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
    public class BriarheartBurger : Entree
    {
        /// <summary>
        /// if the entree comes with ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// if the entree comes with cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// if the entree comes with pickle
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// if the entree comes with ketchup
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// if the entree comes with mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// THe price of the burger
        /// </summary>
        public override double Price
        {
            get { return 6.32; }
        }

        /// <summary>
        /// The calories of the briarheart burger
        /// </summary>
        public override uint Calories
        {
            get { return 743; }
        }
        
        /// <summary>
         /// A list of special instructions for preparing the briarheart burger
         /// </summary>
        public override List<string> SpecialInstructions
        {
            get {
                List<string> instruc = new List<string>();
                if (!Ketchup) instruc.Add("Hold ketchup");
                if (!Bun) instruc.Add("Hold bun");
                if (!Mustard) instruc.Add("Hold mustard");
                if (!Cheese) instruc.Add("Hold cheese");
                if (!Pickle) instruc.Add("Hold pickle");
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
