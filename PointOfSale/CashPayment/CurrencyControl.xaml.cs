using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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
    public partial class CurrencyControl : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// Propertychange handler for customer quantity and change quantity changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// backing vars
        /// </summary>
        private int customerQuantity = 0;
        private int changeQuantity = 0;

        /// <summary>
        /// The text displayed on this component (describes the denomination of cash)
        /// </summary>
        public string Label { get; }
        
        /// <summary>
        /// The quantitiy of bills/coins from the customer
        /// </summary>
        public int CustomerQuantity
        {
            get => customerQuantity;
            set
            {
                customerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuantity"));
            }
        }

        /// <summary>
        /// the quantity of bills/cash provided as change
        /// </summary>
        public int ChangeQuantity
        {
            get => changeQuantity;
            set
            {
                changeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuantity"));
            }
        }
        
        /// <summary>
        /// contstructor. The label/denomination of cash this control represents is provided as argument s
        /// </summary>
        /// <param name="s"></param>
        public CurrencyControl(string s)
        {
            Label = s;
            InitializeComponent();
            IncreaseCustomerQuantity.Click += (o, i) => { CustomerQuantity++; };
            DecreaseCustomerQuantity.Click += (o, i) => { CustomerQuantity--; };
        }
    }
}
