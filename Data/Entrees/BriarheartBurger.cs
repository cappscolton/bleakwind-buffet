﻿/*
* Author: Colton Capps
* Class name: BriarheartBurger.cs
* Purpose: Represent an entree on the menu at Bleakwind
* Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the briarheart burger entree
    /// </summary>
    public class BriarheartBurger : Entree, INotifyPropertyChanged
    {
        private bool ketchup = true;
        private bool cheese = true;
        private bool bun = true;
        private bool pickle = true;
        private bool mustard = true;

        /// <summary>
        /// A description of a this entree
        /// </summary>
        public override string Description
        {
            get { return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese."; }
        }

        /// <summary>
        /// event for implementing PropertyChange notifications
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

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

        /// <summary>
        /// if the entree comes with ketchup, notifies propterychanged handler on changes for this property and 
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
