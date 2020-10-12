/*
* Author: Colton Capps
* Class name: SailorSodaCustomizer.cs
* Purpose: Create a user control for customizing a drink
*/

using BleakwindBuffet.Data;
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
using System.Linq;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SailorSodaCustomizer.xaml
    /// </summary>
    public partial class SailorSodaCustomizer : Customizer
    {
        public List<BleakwindBuffet.Data.Enums.SodaFlavor> Flavors => System.Enum.GetValues(typeof(BleakwindBuffet.Data.Enums.SodaFlavor)).Cast<BleakwindBuffet.Data.Enums.SodaFlavor>().ToList();

        public SailorSodaCustomizer()
        {
            InitializeComponent();
            SizeComboBox.ItemsSource = Sizes;
            FlavorComboBox.ItemsSource = Flavors;
        }
    }
}
