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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboCustomizer.xaml
    /// </summary>
    public partial class ComboSelection : Customizer
    {
        private IOrderItem drink;
        private IOrderItem entree;
        private IOrderItem side;

        public IOrderItem Drink { get => drink; set => drink = value; }
        public IOrderItem Entree { get => entree; set => entree = value; }
        public IOrderItem Side { get => side; set => side = value; }

        public ComboSelection()
        {
            InitializeComponent();
            EntreeComboBox.ItemsSource = BleakwindBuffet.Data.Menu.Entrees().ToList();
            DrinkComboBox.ItemsSource = BleakwindBuffet.Data.Menu.Drinks().ToList();
            SideComboBox.ItemsSource = BleakwindBuffet.Data.Menu.Sides().ToList();
        }

        public void customizeComboItems(object sender, RoutedEventArgs e)
        {
            ComboCustomizer c = new ComboCustomizer(Entree, Drink, Side);
            OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
            w.PrimaryMenuBorder.Child = c;
        }
    }
}
