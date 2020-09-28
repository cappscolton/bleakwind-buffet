/*
* Author: Colton Capps
* Class name: MainSelectionComponent.cs
* Purpose: User control used to navigate between customizing menu items through buttons
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelectionComponent.xaml
    /// </summary>
    public partial class MenuSelectionComponent : UserControl
    {
        public MenuSelectionComponent()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Finds correct customization menu from button pressed and tells the upper level component to dislpay it.
        /// </summary>
        /// <param name="sender">button click args</param>
        /// <param name="e">button click args</param>
        void enterCustomizationMenu(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
            w.changePrimaryMenu((string)b.Content);
        }
    }
}
