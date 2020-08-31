using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class AretinoAppleJuice
    {
        private bool ice = false;

        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 44;
                    case Size.Medium:
                        return 88;
                    case Size.Large:
                        return 132;
                    default:
                        return 44;
                }
            }
        }
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 0.62;
                    case Size.Medium:
                        return 0.87;
                    case Size.Large:
                        return 1.01;
                    default:
                        return 0.62;
                }
            }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (ice) instruc.Add("Add ice");
                return instruc;
            }
        }
        private Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        override public string ToString()
        {
            string sz;
            switch (size)
            {
                case Size.Small:
                    sz = "Small ";
                    break;
                case Size.Medium:
                    sz = "Medium ";
                    break;
                case Size.Large:
                    sz = "Large ";
                    break;
                default:
                    sz = "Small ";
                    break;
            }
            
            return sz + "Aretino Apple Juice";
        }
    }
}
