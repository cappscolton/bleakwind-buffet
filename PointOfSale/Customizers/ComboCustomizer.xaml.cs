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
    /*
    public void EditCustomization(IOrderItem item)
    {
        if (item == null) return;
        if (item is BriarheartBurger)
        {
            PrimaryMenuBorder.Child = new BriarheartBurgerCustomizer();
            BriarheartBurgerCustomizer c = PrimaryMenuBorder.Child as BriarheartBurgerCustomizer;
            c.DataContext = item as BriarheartBurger;
        }
        if (item is DoubleDraugr)
        {
            PrimaryMenuBorder.Child = new DoubleDraugerCustomizer();
            DoubleDraugerCustomizer c = PrimaryMenuBorder.Child as DoubleDraugerCustomizer;
            c.DataContext = item as DoubleDraugr;
        }
        if (item is ThalmorTriple)
        {
            PrimaryMenuBorder.Child = new ThalmorTripleCustomizer();
            ThalmorTripleCustomizer c = PrimaryMenuBorder.Child as ThalmorTripleCustomizer;
            c.DataContext = item as ThalmorTriple;
        }
        if (item is GardenOrcOmelette)
        {
            PrimaryMenuBorder.Child = new GardenOrcOmeletteCustomizer();
            GardenOrcOmeletteCustomizer c = PrimaryMenuBorder.Child as GardenOrcOmeletteCustomizer;
            c.DataContext = item as GardenOrcOmelette;
        }
        if (item is PhillyPoacher)
        {
            PrimaryMenuBorder.Child = new PhillyPoacherCustomizer();
            PhillyPoacherCustomizer c = PrimaryMenuBorder.Child as PhillyPoacherCustomizer;
            c.DataContext = item as PhillyPoacher;
        }
        if (item is SmokehouseSkeleton)
        {
            PrimaryMenuBorder.Child = new SmokehouseSkeletonCustomizer();
            SmokehouseSkeletonCustomizer c = PrimaryMenuBorder.Child as SmokehouseSkeletonCustomizer;
            c.DataContext = item as SmokehouseSkeleton;
        }

        if (item is DragonbornWaffleFries)
        {
            PrimaryMenuBorder.Child = new SideCustomizer();
            SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
            c.DataContext = item as DragonbornWaffleFries;
        }
        if (item is FriedMiraak)
        {
            PrimaryMenuBorder.Child = new SideCustomizer();
            SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
            c.DataContext = item as FriedMiraak;
        }
        if (item is MadOtarGrits)
        {
            PrimaryMenuBorder.Child = new SideCustomizer();
            SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
            c.DataContext = item as MadOtarGrits;
        }
        if (item is VokunSalad)
        {
            PrimaryMenuBorder.Child = new SideCustomizer();
            SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
            c.DataContext = item as VokunSalad;
        }
        if (item is AretinoAppleJuice)
        {
            PrimaryMenuBorder.Child = new AretinoAppleJuiceCustomizer();
            AretinoAppleJuiceCustomizer c = PrimaryMenuBorder.Child as AretinoAppleJuiceCustomizer;
            c.DataContext = item as AretinoAppleJuice;
        }
        if (item is CandlehearthCoffee)
        {
            PrimaryMenuBorder.Child = new CandlehearthCoffeeCustomizer();
            CandlehearthCoffeeCustomizer c = PrimaryMenuBorder.Child as CandlehearthCoffeeCustomizer;
            c.DataContext = item as CandlehearthCoffee;
        }
        if (item is MarkarthMilk)
        {
            PrimaryMenuBorder.Child = new MarkarthMilkCustomizer();
            MarkarthMilkCustomizer c = PrimaryMenuBorder.Child as MarkarthMilkCustomizer;
            c.DataContext = item as MarkarthMilk;
        }
        if (item is SailorSoda)
        {
            PrimaryMenuBorder.Child = new SailorSodaCustomizer();
            SailorSodaCustomizer c = PrimaryMenuBorder.Child as SailorSodaCustomizer;
            c.DataContext = item as SailorSoda;
        }
        if (item is WarriorWater)
        {
            PrimaryMenuBorder.Child = new WarriorWaterCustomizer();
            WarriorWaterCustomizer c = PrimaryMenuBorder.Child as WarriorWaterCustomizer;
            c.DataContext = item as WarriorWater;
        }
    }
    */
}
