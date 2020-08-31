using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class SmokehouseSkeleton
    {

        private bool hashBrowns = true;
        private bool pancake = true;
        private bool sausageLink = true;
        private bool egg = true;

        public double Price 
        {
            get { return 5.62; }
        }

        public uint Calories
        {
            get { return 602; }
        }
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }
        
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set { hashBrowns = value; }
        }
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruc = new List<string>();
                if (!hashBrowns) instruc.Add("Hold hash browns");
                if (!sausageLink) instruc.Add("Hold sausage");
                if (!egg) instruc.Add("Hold eggs");
                if (!pancake) instruc.Add("Hold pancakes");
                return instruc;
            }
        }
        override public string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
