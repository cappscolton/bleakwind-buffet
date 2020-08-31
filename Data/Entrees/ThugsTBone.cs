/*
* Author: Colton Capps
* Class name: ThugsTBone.cs
* Purpose: Represent an entree on the menu at Bleakwind 
* Juicy T-Bone not much else to say
*/



using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThugsTBone
    {
        
        public double Price
        {
            get { return 6.44; }
        }

        public uint Calories
        {
            get { return 982; }
        }
        
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }
        override public string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
