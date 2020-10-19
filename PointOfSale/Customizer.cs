    using BleakwindBuffet.Data;
using System.Linq;
using BleakwindBuffet.Data.Enums;
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
using System;

namespace PointOfSale
{
    public partial class Customizer : UserControl
    {
        /// <summary>
        /// Generates a list from the values stored in Sizes enum. Used for displaying the values in a combobox.
        /// </summary>
        public List<BleakwindBuffet.Data.Enums.Size> Sizes => Enum.GetValues(typeof(BleakwindBuffet.Data.Enums.Size)).Cast<BleakwindBuffet.Data.Enums.Size>().ToList();

        /// <summary>
        /// A buttonclick event for completion of a customization.
        /// When this fires, the main window must change and the item must be added to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void finishCustomizing(object sender, RoutedEventArgs e)
        {
            //add to order component text
            Button b = sender as Button;
            OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
            Order o = w.DataContext as Order;
            if (!o.Contains(DataContext as IOrderItem))
            {
                o.Add(this.DataContext as IOrderItem);
            }
            w.changePrimaryMenu("Selection");
            w.OrderListView.SelectedItem = null;
        }
        /// <summary>
        /// Remove from order and return to main menu
        /// </summary>
        /// <param name="sender">click event args</param>
        /// <param name="e">click event args</param>using System;using System;using System;
        public void cancelCustomizing(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
            w.changePrimaryMenu("Selection");
            w.OrderListView.SelectedItem = null;
        }
    }
}
