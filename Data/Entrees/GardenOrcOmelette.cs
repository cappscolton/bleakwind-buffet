/*
* Author: Colton Capps
* Class name: GardenOrcOmelette.cs
* Purpose: Represent an entree on the menu at Bleakwind: 
* Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the garden orc omelette entree
    /// </summary>
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        private bool broccoli = true;
        private bool cheddar = true;
        private bool mushrooms = true;
        private bool tomato = true;


        /// <summary>
        /// if the entree comes with broccoli, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Brocolli"));
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
        /// if the entree comes with cheddar, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// if the entree comes with mushrooms, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

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
