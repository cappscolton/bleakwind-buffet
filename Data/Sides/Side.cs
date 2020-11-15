using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing a side item
    /// </summary>
    public abstract class Side : IOrderItem
    {
        public abstract event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        ///  The price of the side
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        ///  The number of calories in the side
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Any special instructions for preparing the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public virtual string Name => ToString();

        /// <summary>
        /// A description of a this side
        /// </summary>
        public abstract string Description
        {
            get;
        }
    }
}
