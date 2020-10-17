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
        /// <summary>
        /// Constructor for this UserControl.
        /// Creates a new Order which can be treated as a List for
        /// displaying it's contents dynamically within a ListView.
        /// </summary>
       public OrderComponent()
        {
            InitializeComponent();
            DataContext = new Order();
            OrderListView.ItemsSource = (DataContext as Order);
            OrderListView.SelectionChanged += OrderListView_SelectionChanged;
        }

        /// <summary>
        /// Buttonclick event for removing the SelectedItem from the Order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void removeItem(object sender, RoutedEventArgs e)
        {
            Order o = DataContext as Order;
            o.Remove(OrderListView.SelectedItem as IOrderItem);
            changePrimaryMenu("Selection");
        }

        /// <summary>
        /// Listener event. When a new item in the selection changes, the main window should feature
        /// that item's customization controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EditCustomization(OrderListView.SelectedItem as IOrderItem);
        }

        /// <summary>
        /// Turn the main window into the appropriate customization window.
        /// This means the DataContext of that customizer must be set to an existing IOrderItem.
        /// </summary>
        /// <param name="item"></param>
        public void EditCustomization(IOrderItem item)
        {
            if (item == null) return;
            if (item is BriarheartBurger) {
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
                        MenuSelectionComponent c = PrimaryMenuBorder.Child as MenuSelectionComponent;
                        c.DataContext = null;
                        break;
                    }
                    
                case "Briarheart Burger":
                    {
                        PrimaryMenuBorder.Child = new BriarheartBurgerCustomizer();
                        BriarheartBurgerCustomizer c = PrimaryMenuBorder.Child as BriarheartBurgerCustomizer;
                        c.DataContext = new BriarheartBurger();
                        break;
                    }
                    
                case "Double Draugr":
                    {
                        PrimaryMenuBorder.Child = new DoubleDraugerCustomizer();
                        DoubleDraugerCustomizer c = PrimaryMenuBorder.Child as DoubleDraugerCustomizer;
                        c.DataContext = new DoubleDraugr();
                        break;
                    }
                    
                case "Garden Orc Omelette":
                    {
                        PrimaryMenuBorder.Child = new GardenOrcOmeletteCustomizer();
                        GardenOrcOmeletteCustomizer c = PrimaryMenuBorder.Child as GardenOrcOmeletteCustomizer;
                        c.DataContext = new GardenOrcOmelette();
                        break;
                    }
                case "Philly Poacher":
                    {
                        PrimaryMenuBorder.Child = new PhillyPoacherCustomizer();
                        PhillyPoacherCustomizer c = PrimaryMenuBorder.Child as PhillyPoacherCustomizer;
                        c.DataContext = new PhillyPoacher();
                        break;
                    }
                    
                case "Smokehouse Skeleton":
                    {
                        PrimaryMenuBorder.Child = new SmokehouseSkeletonCustomizer();
                        SmokehouseSkeletonCustomizer c = PrimaryMenuBorder.Child as SmokehouseSkeletonCustomizer;
                        c.DataContext = new SmokehouseSkeleton();
                        break;
                    }
                    
                case "Thalmor Triple":
                    {
                        PrimaryMenuBorder.Child = new ThalmorTripleCustomizer();
                        ThalmorTripleCustomizer c = PrimaryMenuBorder.Child as ThalmorTripleCustomizer;
                        c.DataContext = new ThalmorTriple();
                        break;
                    }
                    
                case "Thugs T-Bone":
                    {
                        PrimaryMenuBorder.Child = new MenuSelectionComponent();
                        MenuSelectionComponent c = PrimaryMenuBorder.Child as MenuSelectionComponent;
                        c.DataContext = new ThugsTBone();
                        break;
                    }
                    
                case "Dragonborn Waffle Fries":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
                        c.DataContext = new DragonbornWaffleFries();
                        break;
                    }
                    
                case "Fried Miraak":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
                        c.DataContext = new FriedMiraak();
                        break;
                    }
                    
                case "Mad Otar Grits":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
                        c.DataContext = new MadOtarGrits();
                        break;
                    }
                    
                case "Vokun Salad":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
                        c.DataContext = new VokunSalad();
                        break;
                    }
                    
                case "Aretino Apple Juice":
                    {
                        PrimaryMenuBorder.Child = new AretinoAppleJuiceCustomizer();
                        AretinoAppleJuiceCustomizer c = PrimaryMenuBorder.Child as AretinoAppleJuiceCustomizer;
                        c.DataContext = new AretinoAppleJuice();
                        break;
                    }
                    
                case "Candlehearth Coffee":
                    {
                        PrimaryMenuBorder.Child = new CandlehearthCoffeeCustomizer();
                        CandlehearthCoffeeCustomizer c = PrimaryMenuBorder.Child as CandlehearthCoffeeCustomizer;
                        c.DataContext = new CandlehearthCoffee();
                        break;
                    }
                    
                case "Markarth Milk":
                    {
                        PrimaryMenuBorder.Child = new MarkarthMilkCustomizer();
                        MarkarthMilkCustomizer c = PrimaryMenuBorder.Child as MarkarthMilkCustomizer;
                        c.DataContext = new MarkarthMilk();
                        break;
                    }
                    
                case "Warrior Water":
                    {
                        PrimaryMenuBorder.Child = new WarriorWaterCustomizer();
                        WarriorWaterCustomizer c = PrimaryMenuBorder.Child as WarriorWaterCustomizer;
                        c.DataContext = new WarriorWater();
                        break;
                    }
                    
                case "Sailor Soda":
                    {
                        PrimaryMenuBorder.Child = new SailorSodaCustomizer();
                        SailorSodaCustomizer c = PrimaryMenuBorder.Child as SailorSodaCustomizer;
                        c.DataContext = new SailorSoda();
                        break;
                    }
                    
                case null:
                    break;
            }

        }

        void cancelOrder(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            DataContext = new Order();
            OrderListView.ItemsSource = DataContext as Order;
        }
    }
}
