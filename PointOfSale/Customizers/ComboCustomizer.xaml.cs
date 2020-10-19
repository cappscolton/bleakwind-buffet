using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboCustomizer.xaml
    /// </summary>
    public partial class ComboCustomizer : Customizer
    {
        public ComboCustomizer(IOrderItem e, IOrderItem d, IOrderItem s)
        {
            InitializeComponent();
            createThreeCustomizers(e, d, s);
            DataContext = new Combo(e, d, s);
        }

        public void createThreeCustomizers(IOrderItem e, IOrderItem d, IOrderItem s)
        {
            List<Customizer> c = new List<Customizer>();
            foreach (IOrderItem i in new List<IOrderItem> { e, d, s })
            {
                if (i == null) return;
                Customizer customizer = null;
                if (i is BriarheartBurger)
                    customizer = new BriarheartBurgerCustomizer();
                if (i is DoubleDraugr)
                    customizer = new DoubleDraugerCustomizer();
                if (i is ThalmorTriple)
                    customizer = new ThalmorTripleCustomizer();
                if (i is GardenOrcOmelette)
                    customizer = new GardenOrcOmeletteCustomizer();
                if (i is PhillyPoacher)
                    customizer = new PhillyPoacherCustomizer();
                if (i is SmokehouseSkeleton)
                    customizer = new SmokehouseSkeletonCustomizer();
                if (i is DragonbornWaffleFries)
                    customizer = new SideCustomizer();
                if (i is FriedMiraak)
                    customizer = new SideCustomizer();
                if (i is MadOtarGrits)
                    customizer = new SideCustomizer();
                if (i is VokunSalad)
                    customizer = new SideCustomizer();
                if (i is AretinoAppleJuice)
                    customizer = new AretinoAppleJuiceCustomizer();
                if (i is CandlehearthCoffee)
                    customizer = new CandlehearthCoffeeCustomizer();
                if (i is MarkarthMilk)
                    customizer = new MarkarthMilkCustomizer();
                if (i is SailorSoda)
                    customizer = new SailorSodaCustomizer();
                if (i is WarriorWater)
                    customizer = new WarriorWaterCustomizer();
                if (customizer == null) return;
                customizer.DataContext = i;
                c.Add(customizer);
            }
            item1Border.Child = c[0];
            item2Border.Child = c[1];
            item3Border.Child = c[2];

            item1Border.Child = c[0];
            item2Border.Child = c[1];
            item3Border.Child = c[2];



        }
    }
}
