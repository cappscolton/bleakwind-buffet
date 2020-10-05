using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for ThalmorTripleCustomizer.xaml
    /// </summary>
    public partial class ThalmorTripleCustomizer : UserControl
    {
        public ThalmorTripleCustomizer()
        {
            InitializeComponent();
            this.DataContext = new ThalmorTriple();
        }
        void finishCustomizing(object sender, RoutedEventArgs e)
        {
            //add to order component text
            Button b = sender as Button;
            OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
            w.OrderText.Text += "\n" + DataContext.ToString();
            w.changePrimaryMenu("Selection");
        }

        void cancelCustomizing(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
            w.changePrimaryMenu("Selection");
        }
    }
}
