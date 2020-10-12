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
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IOrderItem drink = new AretinoAppleJuice();
        private IOrderItem side = new VokunSalad();
        private IOrderItem entree = new BriarheartBurger();
        public IOrderItem Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink.PropertyChanged -= PropertyChangeListner;
                drink = value;
                drink.PropertyChanged += PropertyChangeListner;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        public IOrderItem Side
        {
            get
            {
                return side;
            }
            set
            {
                side.PropertyChanged -= PropertyChangeListner;
                side = value;
                side.PropertyChanged += PropertyChangeListner;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        public IOrderItem Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree.PropertyChanged -= PropertyChangeListner;
                entree = value;
                Entree.PropertyChanged += PropertyChangeListner;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public double Price => (drink.Price + side.Price + entree.Price - 1.00);

        public uint Calories 
        {
            get
            {
                return (drink.Calories + side.Calories + entree.Calories);
            }
        }

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

        void PropertyChangeListner(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price" || e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

    }
}
