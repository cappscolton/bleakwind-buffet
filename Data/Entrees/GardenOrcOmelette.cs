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
    public class GardenOrcOmelette
    {
        private bool tomato = true;
        private bool mushrooms = true;
        private bool broccoli = true;
        private bool cheddar = true;

        public double Price
        {
            get { return 4.57; }
        }

        public uint Calories
        {
            get { return 404; }
        }
        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }

        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
        }
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
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
        override public string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
