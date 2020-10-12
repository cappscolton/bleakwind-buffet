using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Base class for entree items implementing IOrderItem
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        public abstract event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The price of the entree
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// The number of calories in the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// The special instructions for preparing the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}