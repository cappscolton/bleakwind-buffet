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
            DataContext = new Order();
            OrderListView.ItemsSource = (DataContext as Order);
            OrderListView.SelectionChanged += OrderListView_SelectionChanged;
        }

        public void removeItem(object sender, RoutedEventArgs e)
        {
            Order o = DataContext as Order;
            o.Remove(OrderListView.SelectedItem as IOrderItem);
            changePrimaryMenu("Selection");
        }

        private void OrderListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EditCustomization(OrderListView.SelectedItem as IOrderItem);
        }

        public void EditCustomization(IOrderItem item)
        {
            if (item == null) return;
            switch (item.ToString())
            {
                case "Briarheart Burger":
                    {
                        PrimaryMenuBorder.Child = new BriarheartBurgerCustomizer();
                        BriarheartBurgerCustomizer c = PrimaryMenuBorder.Child as BriarheartBurgerCustomizer;
                        c.DataContext = item as BriarheartBurger;
                        break;
                    }

                case "Double Draugr":
                    {
                        PrimaryMenuBorder.Child = new DoubleDraugerCustomizer();
                        DoubleDraugerCustomizer c = PrimaryMenuBorder.Child as DoubleDraugerCustomizer;
                        c.DataContext = item as DoubleDraugr;
                        break;
                    }

                case "Garden Orc Omelette":
                    {
                        PrimaryMenuBorder.Child = new GardenOrcOmeletteCustomizer();
                        GardenOrcOmeletteCustomizer c = PrimaryMenuBorder.Child as GardenOrcOmeletteCustomizer;
                        c.DataContext = item as GardenOrcOmelette;
                        break;
                    }
                case "Philly Poacher":
                    {
                        PrimaryMenuBorder.Child = new PhillyPoacherCustomizer();
                        PhillyPoacherCustomizer c = PrimaryMenuBorder.Child as PhillyPoacherCustomizer;
                        c.DataContext = item as PhillyPoacher;
                        break;
                    }

                case "Smokehouse Skeleton":
                    {
                        PrimaryMenuBorder.Child = new SmokehouseSkeletonCustomizer();
                        SmokehouseSkeletonCustomizer c = PrimaryMenuBorder.Child as SmokehouseSkeletonCustomizer;
                        c.DataContext = item as SmokehouseSkeleton;
                        break;
                    }

                case "Thalmor Triple":
                    {
                        PrimaryMenuBorder.Child = new ThalmorTripleCustomizer();
                        ThalmorTripleCustomizer c = PrimaryMenuBorder.Child as ThalmorTripleCustomizer;
                        c.DataContext = item as ThalmorTriple ;
                        break;
                    }

                case "Thugs T-Bone":
                    {
                        PrimaryMenuBorder.Child = new MenuSelectionComponent();
                        MenuSelectionComponent c = PrimaryMenuBorder.Child as MenuSelectionComponent;
                        c.DataContext = item as ThugsTBone;
                        break;
                    }

                case "Dragonborn Waffle Fries":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
                        c.DataContext = item as DragonbornWaffleFries;
                        break;
                    }

                case "Fried Miraak":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
                        c.DataContext = item as FriedMiraak;
                        break;
                    }

                case "Mad Otar Grits":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
                        c.DataContext = item as MadOtarGrits;
                        break;
                    }

                case "Vokun Salad":
                    {
                        PrimaryMenuBorder.Child = new SideCustomizer();
                        SideCustomizer c = PrimaryMenuBorder.Child as SideCustomizer;
                        c.DataContext = item as VokunSalad;
                        break;
                    }

                case "Aretino Apple Juice":
                    {
                        PrimaryMenuBorder.Child = new AretinoAppleJuiceCustomizer();
                        AretinoAppleJuiceCustomizer c = PrimaryMenuBorder.Child as AretinoAppleJuiceCustomizer;
                        c.DataContext = item as AretinoAppleJuice;
                        break;
                    }

                case "Candlehearth Coffee":
                    {
                        PrimaryMenuBorder.Child = new CandlehearthCoffeeCustomizer();
                        CandlehearthCoffeeCustomizer c = PrimaryMenuBorder.Child as CandlehearthCoffeeCustomizer;
                        c.DataContext = item as CandlehearthCoffee;
                        break;
                    }

                case "Markarth Milk":
                    {
                        PrimaryMenuBorder.Child = new MarkarthMilkCustomizer();
                        MarkarthMilkCustomizer c = PrimaryMenuBorder.Child as MarkarthMilkCustomizer;
                        c.DataContext = item as MarkarthMilk;
                        break;
                    }

                case "Warrior Water":
                    {
                        PrimaryMenuBorder.Child = new WarriorWaterCustomizer();
                        WarriorWaterCustomizer c = PrimaryMenuBorder.Child as WarriorWaterCustomizer;
                        c.DataContext = item as WarriorWater;
                        break;
                    }

                case "Sailor Soda":
                    {
                        PrimaryMenuBorder.Child = new SailorSodaCustomizer();
                        SailorSodaCustomizer c = PrimaryMenuBorder.Child as SailorSodaCustomizer;
                        c.DataContext = item as SailorSoda;
                        break;
                    }

                case null:
                    break;
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
