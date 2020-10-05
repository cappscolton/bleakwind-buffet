/*
* Author: Colton Capps
* Class name: SmokehouseSkeleton.cs
* Purpose: Represent an entree on the menu at Bleakwind: 
* Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the smokehouse skeleton entree
    /// </summary>
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// THe price of the smokehouse skeleton
        /// </summary>
        public override double Price 
        {
            get { return 5.62; }
        }

        /// <summary>
        /// The calories of the triple
        /// </summary>
        public override uint Calories
        {
            get { return 602; }
        }

        private bool pancake = true;
        private bool egg = true;
        private bool sausage = true;
        private bool hashbrowns = true;

        /// <summary>
        /// if the entree comes with pancake, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
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
        /// if the entree comes with sausage, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool SausageLink
        {
            get => sausage;
            set
            {
                sausage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// if the entree comes with hashbrowns, notifies propterychanged handler on changes for this property and specialinstructions
        /// </summary>
        public bool HashBrowns
        {
            get => hashbrowns;
            set
            {
                hashbrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// A list of special instructions for preparing the skeleton
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!HashBrowns) instruc.Add("Hold hash browns");
                if (!SausageLink) instruc.Add("Hold sausage");
                if (!Egg) instruc.Add("Hold eggs");
                if (!Pancake) instruc.Add("Hold pancakes");
                return instruc;
            }
        }/// <summary>
         /// Returns a description of the skeleton
         /// </summary>
         /// <returns>A string describing the skeleton</returns>
        override public string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
