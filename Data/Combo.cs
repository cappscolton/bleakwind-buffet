using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A combo representing one drink, one side, and one entree item
    /// The combo has its own values for the properties of an IOrderItem
    /// based on the sum of the items included. Therefore, it can be treated as
    /// one IOrderItem
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Allows us to get notifications when the details of this object have changed so that
        /// the properties can be updated, because the UI that uses this class depends on the value of the properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property for ToString so that the item's name can be updated.
        /// </summary>
        public string Name => ToString();

        /// <summary>
        /// Private backing variables
        /// </summary>
        private IOrderItem drink = new AretinoAppleJuice();
        private IOrderItem side = new VokunSalad();
        private IOrderItem entree = new BriarheartBurger();

        /// <summary>
        /// The Drink item of this combo
        /// When a new item is added, it must subscribe to the listener for this item
        /// </summary>
        public IOrderItem Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink.PropertyChanged -= PropertyChangeListener;
                drink = value;
                drink.PropertyChanged += PropertyChangeListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The side item of this combo
        /// </summary>
        public IOrderItem Side
        {
            get
            {
                return side;
            }
            set
            {
                side.PropertyChanged -= PropertyChangeListener;
                side = value;
                side.PropertyChanged += PropertyChangeListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The entree item of this combo
        /// </summary>
        public IOrderItem Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree.PropertyChanged -= PropertyChangeListener;
                entree = value;
                Entree.PropertyChanged += PropertyChangeListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The sum price of items in the combo
        /// </summary>
        public double Price => (drink.Price + side.Price + entree.Price - 1.00);

        /// <summary>
        /// The sum calories of items in the combo
        /// </summary>
        public uint Calories 
        {
            get
            {
                return (drink.Calories + side.Calories + entree.Calories);
            }
        }

        /// <summary>
        /// A concatenation of specialinstructions and names of items in the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> ret = new List<string>();
                ret.Add(entree.ToString());
                ret = ret.Concat(entree.SpecialInstructions).ToList();
                ret.Add(side.ToString());
                ret = ret.Concat(side.SpecialInstructions).ToList();
                ret.Add(drink.ToString());
                ret = ret.Concat(side.SpecialInstructions).ToList();
                return ret;
            }
        }

        /// <summary>
        /// Listener that the Drink, Entree, and Side IOrderItems must subscribe to
        /// so that the properites of the combo and individual items update simultaneously
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PropertyChangeListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                
            }
            else if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            else if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

    }
}
