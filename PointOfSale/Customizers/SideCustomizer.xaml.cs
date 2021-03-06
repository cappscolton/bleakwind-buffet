﻿
/*
* Author: Colton Capps
* Class name: SideCustomizer.cs
* Purpose: Create a user control for customizing any side item
*/

using BleakwindBuffet.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideCustomizer.xaml
    /// </summary>
    public partial class SideCustomizer : Customizer
    {
        public SideCustomizer()
        {
            InitializeComponent();
            SizeComboBox.ItemsSource = Sizes;
        }
    }
}
