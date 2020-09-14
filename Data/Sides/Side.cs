using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem
    {
        public virtual Size Size { get; set; }
        public abstract double Price { get; }
        public abstract uint Calories { get; }
        public abstract List<string> SpecialInstructions { get; }
    }
}
