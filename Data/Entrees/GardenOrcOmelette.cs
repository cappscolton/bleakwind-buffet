/*
* Author: Colton Capps
* Class name: GardenOrcOmelette.cs
* Purpose: Represent an entree on the menu at Bleakwind: 
* Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the garden orc omelette entree
    /// </summary>
    public class GardenOrcOmelette : Entree
    {
        /// <summary>
        /// The price of the omelette
        /// </summary>
        public override double Price
        {
            get { return 4.57; }
        }

        /// <summary>
        /// The calories of the omelette
        /// </summary>
        public override uint Calories
        {
            get { return 404; }
        }

        /// <summary>
        /// if the entree comes with broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// if the entree comes with cheddar
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// if the entree comes with mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// if the entree comes with tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// A list of special instructions for preparing the omelette
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!Broccoli) instruc.Add("Hold broccoli");
                if (!Cheddar) instruc.Add("Hold cheddar");
                if (!Mushrooms) instruc.Add("Hold mushrooms");
                if (!Tomato) instruc.Add("Hold tomato");
                return instruc;
            }
        }
        
        /// <summary>
         /// Returns a description of the omelette
         /// </summary>
         /// <returns>A string describing the omelette</returns>
        override public string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
