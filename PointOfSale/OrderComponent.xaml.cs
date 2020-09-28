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
        public OrderComponent()
        {
            InitializeComponent();
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
                    PrimaryMenuBorder.Child = new MenuSelectionComponent();
                    break;
                case "Briarheart Burger":
                    PrimaryMenuBorder.Child = new BriarheartBurgerCustomizer();
                    break;
                case "Double Draugr":
                    PrimaryMenuBorder.Child = new DoubleDraugerCustomizer();
                    break;
                case "Garden Orc Omelette":
                    PrimaryMenuBorder.Child = new GardenOrcOmeletteCustomizer();
                    break;
                case "Philly Poacher":
                    PrimaryMenuBorder.Child = new PhillyPoacherCustomizer();
                    break;
                case "Smokehouse Skeleton":
                    PrimaryMenuBorder.Child = new SmokehouseSkeletonCustomizer();
                    break;
                case "Thalmor Triple":
                    PrimaryMenuBorder.Child = new ThalmorTripleCustomizer();
                    break;
                case "Thugs T-Bone":
                    PrimaryMenuBorder.Child = new MenuSelectionComponent();
                    break;
                case "Dragonborn Waffle Fries":
                    PrimaryMenuBorder.Child = new SideCustomizer();
                    break;
                case "Fried Miraak":
                    PrimaryMenuBorder.Child = new SideCustomizer();
                    break;
                case "Mad Otar Grits":
                    PrimaryMenuBorder.Child = new SideCustomizer();
                    break;
                case "Vokun Salad":
                    PrimaryMenuBorder.Child = new SideCustomizer();
                    break;
                case "Aretino Apple Juice":
                    PrimaryMenuBorder.Child = new AretinoAppleJuiceCustomizer();
                    break;
                case "Candlehearth Coffee":
                    PrimaryMenuBorder.Child = new CandlehearthCoffeeCustomizer();
                    break;
                case "Markarth Milk":
                    PrimaryMenuBorder.Child = new MarkarthMilkCustomizer();
                    break;
                case "Warrior Water":
                    PrimaryMenuBorder.Child = new WarriorWaterCustomizer();
                    break;
                case "Sailor Soda":
                    PrimaryMenuBorder.Child = new SailorSodaCustomizer();
                    break;
                case null:
                    break;
            }

        }
    }
}
