using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class representing a menu of food and drink items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Creates a list of entrees on the menu
        /// </summary>
        /// <returns>IEnumerable of Entrees casted as IOrderItems</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new DoubleDraugr());
            list.Add(new GardenOrcOmelette());
            list.Add(new PhillyPoacher());
            list.Add(new SmokehouseSkeleton());
            list.Add(new ThalmorTriple());
            list.Add(new ThugsTBone());
            return list;
        }
        /// <summary>
        /// Creates a list of sides on the menu
        /// </summary>
        /// <returns>IEnumerable of sides casted as IOrderItems</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries d = new DragonbornWaffleFries();
                FriedMiraak f = new FriedMiraak();
                MadOtarGrits m = new MadOtarGrits();
                VokunSalad v = new VokunSalad();
                d.Size = s;
                f.Size = s;
                m.Size = s;
                v.Size = s;

                list.Add(d);
                list.Add(f);
                list.Add(m);
                list.Add(v);
            }
            
            return list;
        }
        /// <summary>
        /// Creates a list of drinks on the menu
        /// </summary>
        /// <returns>IEnumerable of drinks casted as IOrderItems</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                CandlehearthCoffee cc = new CandlehearthCoffee();
                MarkarthMilk mm = new MarkarthMilk();
                WarriorWater ww = new WarriorWater();
                aj.Size = s;
                cc.Size = s;
                mm.Size = s;
                ww.Size = s;
                list.Add(aj);
                list.Add(cc);
                list.Add(mm);
                list.Add(ww);
            }
            foreach (SodaFlavor f in Enum.GetValues(typeof(SodaFlavor))) 
            {
                foreach (Size s in Enum.GetValues(typeof(Size)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = s;
                    ss.Flavor = f;
                    list.Add(ss);
                }
            }

            return list;
        }
        /// <summary>
        /// Creates a list of all items on the menu
        /// </summary>
        /// <returns>IEnumerable of entrees, drinks, and sides casted as IOrderItems</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            return Entrees().Concat(Sides()).Concat(Drinks());
        }
    }
}
