using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing a drink and implementing iorderitem
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// The price of the drink
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// The number of calories in the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// The special instructions for preparing the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}