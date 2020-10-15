using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface to be implemented by items orderable on the menu (drinks, entrees, and sides)
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Assign a new PropertyChanged event handler to each IOrderItem because they all can be customized.
        /// </summary>
        new event PropertyChangedEventHandler PropertyChanged;
        string Name { get; }
        /// <summary>
        ///  The price of the item
        /// </summary>
        double Price { get; }
        /// <summary>
        ///  The number of calories in the item
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Any special instructions for preparing the item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
