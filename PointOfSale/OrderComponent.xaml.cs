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
using BleakwindBuffet;

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
            Customizer customizer = null;
            if (item is BriarheartBurger)
                customizer = new BriarheartBurgerCustomizer();
            if (item is DoubleDraugr)
                customizer = new DoubleDraugerCustomizer();
            if (item is ThalmorTriple)
                customizer = new ThalmorTripleCustomizer();
            if (item is GardenOrcOmelette)
                customizer = new GardenOrcOmeletteCustomizer();
            if (item is PhillyPoacher)
                customizer = new PhillyPoacherCustomizer();
            if (item is SmokehouseSkeleton)
                customizer = new SmokehouseSkeletonCustomizer();
            if (item is DragonbornWaffleFries)
                customizer = new SideCustomizer();
            if (item is FriedMiraak)
                customizer = new SideCustomizer();
            if (item is MadOtarGrits)
                customizer = new SideCustomizer();
            if (item is VokunSalad)
                customizer = new SideCustomizer();
            if (item is AretinoAppleJuice)
                customizer = new AretinoAppleJuiceCustomizer();
            if (item is CandlehearthCoffee)
                customizer = new CandlehearthCoffeeCustomizer();
            if (item is MarkarthMilk)
                customizer = new MarkarthMilkCustomizer();
            if (item is SailorSoda)
                customizer = new SailorSodaCustomizer();
            if (item is WarriorWater)
                customizer = new WarriorWaterCustomizer();
            if (item is Combo combo)
            {
                customizer = new ComboCustomizer(combo.Entree, combo.Drink, combo.Side);
            }
            if (item is null) return;
            PrimaryMenuBorder.Child = customizer;
            customizer.DataContext = item;
        }

        /// <summary>
        /// Changes the usercontrol of the main menu contained within the ordercomponent
        /// </summary>
        /// <param name="customizer">a string describing the control to go to</param>
        public void changePrimaryMenu(string customizer)
        {
            switch (customizer)
            {
                case "Create A Combo":
                    {
                        PrimaryMenuBorder.Child = new ComboSelection();
                        ComboSelection c = PrimaryMenuBorder.Child as ComboSelection;
                        c.DataContext = new Combo();
                        break;

                    }
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

        /// <summary>
        /// Returns to menu selection screen and creates new DataContext Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cancelOrder(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            DataContext = new Order();
            OrderListView.ItemsSource = DataContext as Order;
        }


        /// <summary>
        /// Enters Payment mode selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void payForOrder(object sender, RoutedEventArgs e)
        {
            PrimaryMenuBorder.Child = new PaymentComponent();
        }
    }
}
