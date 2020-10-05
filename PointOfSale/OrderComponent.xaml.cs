/*
* Author: Colton Capps
* Class name: OrderComponent.cs
* Purpose: Highest level user component containing a main menu and order details and totals
*/
using System;
using System.Collections.Generic;
using System.Linq;
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        
        public double subtotal = 0.00;
        public double tax => subtotal * 93.5;
        public double total => subtotal - tax;

        public OrderComponent()
        {
            InitializeComponent();
        }

        public void addToTotal()
        {
            subtotal += (DataContext as IOrderItem).Price;
        }

        /// <summary>
        /// Changes the usercontrol of the main menu contained within the ordercomponent
        /// </summary>
        /// <param name="customizer">a string describing the control to go to</param>
        public void changePrimaryMenu(string customizer)
        {
            switch (customizer)
            {
                case "Selection":
                    {
                        PrimaryMenuBorder.Child = new MenuSelectionComponent();
                        this.DataContext = null;
                        break;
                    }
                    
                case "Briarheart Burger":
                    {
                        PrimaryMenuBorder.Child = new BriarheartBurgerCustomizer();
                        this.DataContext = new BriarheartBurger();
                        break;
                    }
                    
                case "Double Draugr":
                    {
                        PrimaryMenuBorder.Child = new DoubleDraugerCustomizer();
                        this.DataContext = new DoubleDraugr();
                        break;
                    }
                    
                case "Garden Orc Omelette":
                    {
                        PrimaryMenuBorder.Child = new GardenOrcOmeletteCustomizer();
                        this.DataContext = new GardenOrcOmelette();
                        break;
                    }
                case "Philly Poacher":
                    {
                        PrimaryMenuBorder.Child = new PhillyPoacherCustomizer();
                        this.DataContext = new PhillyPoacher();
                        break;
                    }
                    
                case "Smokehouse Skeleton":
                    {
                        PrimaryMenuBorder.Child = new SmokehouseSkeletonCustomizer();
                        this.DataContext = new SmokehouseSkeleton();
                        break;
                    }
                    
                case "Thalmor Triple":
                    {
                        PrimaryMenuBorder.Child = new ThalmorTripleCustomizer();
                        this.DataContext = new ThalmorTriple();
                        break;
                    }
                    
                case "Thugs T-Bone":
                    {
                        PrimaryMenuBorder.Child = new MenuSelectionComponent();
                        this.DataContext = new ThugsTBone();
                        break;
                    }
                    
                case "Dragonborn Waffle Fries":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        this.DataContext = new DragonbornWaffleFries();
                        break;
                    }
                    
                case "Fried Miraak":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        this.DataContext = new FriedMiraak();
                        break;
                    }
                    
                case "Mad Otar Grits":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        this.DataContext = new MadOtarGrits();
                        break;
                    }
                    
                case "Vokun Salad":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        this.DataContext = new VokunSalad();
                        break;
                    }
                    
                case "Aretino Apple Juice":
                    {
                        PrimaryMenuBorder.Child = new AretinoAppleJuiceCustomizer();
                        this.DataContext = new AretinoAppleJuice();
                        break;
                    }
                    
                case "Candlehearth Coffee":
                    {
                        PrimaryMenuBorder.Child = new CandlehearthCoffeeCustomizer();
                        this.DataContext = new CandlehearthCoffee();
                        break;
                    }
                    
                case "Markarth Milk":
                    {
                        PrimaryMenuBorder.Child = new MarkarthMilkCustomizer();
                        this.DataContext = new MarkarthMilk();
                        break;
                    }
                    
                case "Warrior Water":
                    {
                        PrimaryMenuBorder.Child = new WarriorWaterCustomizer();
                        this.DataContext = new WarriorWater();
                        break;
                    }
                    
                case "Sailor Soda":
                    {
                        PrimaryMenuBorder.Child = new SailorSodaCustomizer();
                        this.DataContext = new SailorSoda();
                        break;
                    }
                    
                case null:
                    break;
            }

        }
    }
}
