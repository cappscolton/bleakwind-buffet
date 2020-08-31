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
    class ThalmorTriple
    {
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
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }
        public double Price
        {
            get { return 8.32; }
        }
        public uint Calories
        {
            get { return 943; }
        }
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

        override public string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
