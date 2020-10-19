using PointOfSale.CashPayment;
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
using BleakwindBuffet.Data;
using System.Xml.Schema;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentComponent.xaml
    /// </summary>
    public partial class CashPaymentComponent : UserControl
    {
        /// <summary>
        /// The currency controls within this. Must be passed to the MV class
        /// </summary>
        public CurrencyControl penny;
        public CurrencyControl nickel;
        public CurrencyControl dime;
        public CurrencyControl quarter;
        public CurrencyControl halfDollar;
        public CurrencyControl dollar;
        public CurrencyControl one;
        public CurrencyControl two;
        public CurrencyControl five;
        public CurrencyControl ten;
        public CurrencyControl twenty;
        public CurrencyControl fifty;
        public CurrencyControl hundred;

        /// <summary>
        /// The total cost of the order. Must be passed down for calculations.
        /// </summary>
        public double Total { get; set; }

        /// <summary>
        /// Constructor. Creates all the CurrencyControls and assigns them denominations. Assigns datacontext to CPI (MV)
        /// </summary>
        /// <param name="total">takes in total cost to be passed down through calculations</param>
        public CashPaymentComponent(double total)
        {
            InitializeComponent();
            penny = new CurrencyControl("1¢");
            nickel = new CurrencyControl("5¢");
            dime = new CurrencyControl("10¢");
            quarter = new CurrencyControl("25¢");
            halfDollar = new CurrencyControl("50¢");
            dollar = new CurrencyControl("$1");
            one = new CurrencyControl("$1");
            two = new CurrencyControl("$2");
            five = new CurrencyControl("$5");
            ten = new CurrencyControl("$10");
            twenty = new CurrencyControl("$20");
            fifty = new CurrencyControl("$50");
            hundred = new CurrencyControl("$100");
            Total = total;

            CashPaymentIntermediary cpi = new CashPaymentIntermediary(total, this);
            DataContext = cpi;

            Bills.Children.Add(hundred);
            Bills.Children.Add(fifty);
            Bills.Children.Add(twenty);
            Bills.Children.Add(ten);
            Bills.Children.Add(five);
            Bills.Children.Add(two);
            Bills.Children.Add(one);
            
            Coins.Children.Add(dollar);
            Coins.Children.Add(halfDollar);
            Coins.Children.Add(quarter);
            Coins.Children.Add(dime);
            Coins.Children.Add(nickel);
            Coins.Children.Add(penny);
        }

        /// <summary>
        /// Returns to menu selection screen (exiting payment)
        /// Bound to a button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void returnToOrder(object sender, RoutedEventArgs e)
        {
            OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
            w.changePrimaryMenu("Selection");
            w.OrderListView.SelectedItem = null;
        }

        /// <summary>
        /// Finalizes the sale and prints a receipt.txt
        /// Bound to a button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void finalizeSale(object sender, RoutedEventArgs e)
        {
            OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
            Order o = (w.DataContext as Order);

            RecieptPrinter.PrintLine($"Order Number {o.Number + 1}");
            RecieptPrinter.PrintLine($"{DateTime.Now}");
            RecieptPrinter.PrintLine($"Order Details:");
            foreach (IOrderItem i in o)
            {
                RecieptPrinter.PrintLine($"{i.Name}     {i.Price:C2}");
                foreach (string s in i.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine($"     -{s}");
                }

            }
            RecieptPrinter.PrintLine($"Subtotal: {o.Subtotal:C2}");
            RecieptPrinter.PrintLine($"Tax: {o.Tax:C2}");
            RecieptPrinter.PrintLine($"total: {o.Total:C2}");
            RecieptPrinter.PrintLine($"Payment Method: Cash");
            RecieptPrinter.PrintLine($"Change Owed: {(DataContext as CashPaymentIntermediary).ReceiptChangeOwed:C2}");
            RecieptPrinter.CutTape();

            w.cancelOrder(sender, e);
            w.changePrimaryMenu("Selection");
            w.OrderListView.SelectedItem = null;
        }
    }
}
