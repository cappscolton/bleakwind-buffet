/*
* Author: Colton Capps
* Class name: ThalmorTriple.cs
* Purpose: Represent an entree on the menu at Bleakwind 
* Inlcudes two 1/4lb patties with a 1/2lb patty 
* inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the thalmor triple side item
    /// </summary>
    public class ThalmorTriple : Entree, INotifyPropertyChanged
    {
        private bool ketchup = true;
        private bool cheese = true;
        private bool bun = true;
        private bool pickle = true;
        private bool mustard = true;
        private bool mayo = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool bacon = true;
        private bool egg = true;

        /// <summary>
        /// event for implementing PropertyChange notifications
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// A description of a this entree
        /// </summary>
        public override string Description
        {
            get { return "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg."; }
        }

        /// <summary>
        /// if the entree comes with egg, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// if the entree comes with bacon, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set
            {
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// if the entree comes with mayo, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// if the entree comes with lettuce, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// if the entree comes with tomato, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// if the entree comes with ketchup, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// if the entree comes with cheese, notifies propterychanged handler on changes for this property and SpecialInstructions
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// if the entree comes with bun, notifies propterychanged handler on changes for this property and SpecialInstructions
        /// </summary>
        public bool Bun
        {
            get => bun;
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// if the entree comes with pickle, notifies propterychanged handler on changes for this property and SpecialInstructions
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// if the entree comes with mustard, notifies propterychanged handler on changes for this property and SpecialInstructions
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
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
