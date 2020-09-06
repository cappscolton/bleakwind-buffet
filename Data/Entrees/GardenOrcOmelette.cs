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
    public class GardenOrcOmelette
    {
        /* Private variable declaration for omelette */
        private bool tomato = true;
        private bool mushrooms = true;
        private bool broccoli = true;
        private bool cheddar = true;

        /// <summary>
        /// The price of the omelette
        /// </summary>
        public double Price
        {
            get { return 4.57; }
        }

        /// <summary>
        /// The calories of the omelette
        /// </summary>
        public uint Calories
        {
            get { return 404; }
        }

        /// <summary>
        /// if the entree comes with broccoli
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }

        /// <summary>
        /// if the entree comes with cheddar
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        /// <summary>
        /// if the entree comes with mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
        }

        /// <summary>
        /// if the entree comes with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        
        /// <summary>
         /// A list of special instructions for preparing the omelette
         /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!broccoli) instruc.Add("Hold broccoli");
                if (!cheddar) instruc.Add("Hold cheddar");
                if (!mushrooms) instruc.Add("Hold mushrooms");
                if (!tomato) instruc.Add("Hold tomato");
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
