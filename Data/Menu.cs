using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;

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
            Array x = Enum.GetValues(typeof(Size));
            foreach (Size s in x)
            {
                list.Add(new DragonbornWaffleFries() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new FriedMiraak() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new MadOtarGrits() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new VokunSalad() { Size = s });
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
            Array x = Enum.GetValues(typeof(Size));
            foreach (Size s in x)
            {
                list.Add(new AretinoAppleJuice() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new CandlehearthCoffee() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new MarkarthMilk() { Size = s });
            }
            foreach (Size s in x)
            {
                list.Add(new WarriorWater() { Size = s });
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
