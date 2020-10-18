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

namespace PointOfSale.CashPayment
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        private string label = "$1";
        private int customerQuantity = 0;
        private int changeQuantity = 0;

        public string Label
        {
            get => label;
            set
            {
                label = value;
            }
        }

        public int CustomerQuantity
        {
            get => customerQuantity;
            set
            {
                customerQuantity = value;
            }
        }
        public int ChangeQuantity
        {
            get => changeQuantity;
            set
            {
                changeQuantity = value;
            }
        }

        public CurrencyControl()
        {
            InitializeComponent();
        }
    }
}
