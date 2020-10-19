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
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentComponent.xaml
    /// </summary>
    public partial class PaymentComponent : Customizer
    {
        public PaymentComponent()
        {
            InitializeComponent();
        }

        public void PayWithCard(object sender, RoutedEventArgs e)
        {
            Order o = DataContext as Order;
            switch (CardReader.RunCard((DataContext as Order).Total))
            {
                case (CardTransactionResult.Approved):
                    {
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
                        RecieptPrinter.PrintLine($"Payment Method: Card");
                        RecieptPrinter.PrintLine($"Change Owed: $0.00");
                        RecieptPrinter.CutTape();
                        OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
                        w.cancelOrder(sender, e);
                        cancelCustomizing(sender, e);
                        break;
                    }
                case (CardTransactionResult.Declined):
                    {
                        MessageBox.Show("Error Processing Payment: Card Declined");
                        break;
                    }
                case (CardTransactionResult.IncorrectPin):
                    {
                        MessageBox.Show("Error Processing Payment: Incorrect Pin");
                        break;
                    }
                case (CardTransactionResult.InsufficientFunds):
                    {
                        MessageBox.Show("Error Processing Payment: Insufficient Funds");
                        break;
                    }
                case (CardTransactionResult.ReadError):
                    {
                        MessageBox.Show("Error Reading Card: Swipe Again");
                        break;
                    }
            }

        }

        public void PayWithCash(object sender, RoutedEventArgs e)
        {
            OrderComponent w = Window.GetWindow(this).Content as OrderComponent;
            w.PrimaryMenuBorder.Child = new CashPaymentComponent((DataContext as Order).Total);
        }
    }
}
