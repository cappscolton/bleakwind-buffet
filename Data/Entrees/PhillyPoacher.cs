using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class PhillyPoacher
    {
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        public double Price
        {
            get { return 7.23; }
        }

        public uint Calories
        {
            get { return 784; }
        }
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }

        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }

        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!sirloin) instruc.Add("Hold sirloin");
                if (!onion) instruc.Add("Hold onion");
                if (!roll) instruc.Add("Hold roll");
                return instruc;
            }
        }
        override public string ToString()
        {
            return "Philly Poacher";
        }
    }
}
