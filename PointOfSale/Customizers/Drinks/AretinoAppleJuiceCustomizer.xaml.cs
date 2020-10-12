/*
* Author: Colton Capps
* Class name: AretinoAppleJuiceCustomizer.cs
* Purpose: Create a user control for customizing a drink
*/

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
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
using System.Linq;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuiceCustomizer.xaml
    /// </summary>
    public partial class AretinoAppleJuiceCustomizer : Customizer
    {
        public AretinoAppleJuiceCustomizer()
        {
            InitializeComponent();
            SizeComboBox.ItemsSource = Sizes;
        }

        
        

    }
}
