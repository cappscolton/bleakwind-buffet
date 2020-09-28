﻿/*
* Author: Colton Capps
* Class name: WarriorWaterCustomizer.cs
* Purpose: Create a user control for customizing a drink
*/

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
    /// Interaction logic for WarriorWaterCustomizer.xaml
    /// </summary>
    public partial class WarriorWaterCustomizer : UserControl
    {
        public WarriorWaterCustomizer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add to order and return to main menu
        /// </summary>
        /// <param name="sender">click event args</param>
        /// <param name="e">click event args</param>

        void finishCustomizing(object sender, RoutedEventArgs e)
        {
            //add to order component text
            Button b = sender as Button;
            OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
            w.changePrimaryMenu("Selection");
        }
        /// <summary>
        /// Remove from order and return to main menu
        /// </summary>
        /// <param name="sender">click event args</param>
        /// <param name="e">click event args</param>
        void cancelCustomizing(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
            w.changePrimaryMenu("Selection");
        }
    }
}
