using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree : IOrderItem
    {
        public abstract double Price { get; }
        public abstract uint Calories { get; }
        public abstract List<string> SpecialInstructions { get; }
    }
}