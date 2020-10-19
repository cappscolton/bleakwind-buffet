using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using RoundRegister;

namespace PointOfSale.CashPayment
{
    /// <summary>
    /// Modelview class for MVVM for Point of Sale. Connects to CashPaymentComponent
    /// managing amount due and change owed calculations. Displays best way to make change
    /// and allows finalizing sale.
    /// </summary>
    public class CashPaymentIntermediary : INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChangeHandler for customer bill/coin quantities and change quantities to be displayed on gui
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The cpc View class that this connects with
        /// </summary>
        CashPaymentComponent cpc;
        
        /// <summary>
        /// The total cost of the order.
        /// </summary>
        public double Total;

        /// <summary>
        /// Constructor. Assigns total and reference to CPC.
        /// Also attaches propertychanges listeners to all the CurrencyControls in the CPC
        /// so we can process all the changes/events here.
        /// </summary>
        /// <param name="total">Cost of the order</param>
        /// <param name="Cpc">Reference to the View usercontrol where all visual changes are reflected</param>
        public CashPaymentIntermediary(double total, CashPaymentComponent Cpc)
        {
            Total = total;
            cpc = Cpc;
            cpc.penny.PropertyChanged += CustomerQuantityChangeListener;
            cpc.nickel.PropertyChanged += CustomerQuantityChangeListener;
            cpc.dime.PropertyChanged += CustomerQuantityChangeListener;
            cpc.quarter.PropertyChanged += CustomerQuantityChangeListener;
            cpc.halfDollar.PropertyChanged += CustomerQuantityChangeListener;
            cpc.dollar.PropertyChanged += CustomerQuantityChangeListener;
            cpc.one.PropertyChanged += CustomerQuantityChangeListener;
            cpc.two.PropertyChanged += CustomerQuantityChangeListener;
            cpc.five.PropertyChanged += CustomerQuantityChangeListener;
            cpc.ten.PropertyChanged += CustomerQuantityChangeListener;
            cpc.twenty.PropertyChanged += CustomerQuantityChangeListener;
            cpc.fifty.PropertyChanged += CustomerQuantityChangeListener;
            cpc.hundred.PropertyChanged += CustomerQuantityChangeListener;

        }

        /// <summary>
        /// Listener to hear all changes to customer coin/bill quantities so we can recalculate
        /// the amount due and correct change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomerQuantityChangeListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "CustomerQuantity")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerCashTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
                DetermineChangeDenominations();
            }
        }

        /// <summary>
        /// The total amount of cash the customer has provided
        /// </summary>
        public double CustomerCashTotal => (PenniesCoinCustomer * 0.01 +
                NickelsCoinCustomer * 0.05 +
                DimesCoinCustomer * 0.10 +
                QuartersCoinCustomer * 0.25 +
                HalfDollarsCoinCustomer * 0.50 +
                DollarsCoinCustomer * 1.00 +
                OnesBillCustomer * 1.00 +
                TwosBillCustomer * 2.00 +
                FivesBillCustomer * 5.00 +
                TensBillCustomer * 10.00 +
                TwentiesBillCustomer * 20.00 +
                FiftiesBillCustomer * 50.00 +
                HundredsBillCustomer * 100.00);

        /// <summary>
        /// The total amount of change provided to the customer
        /// </summary>
        public double ChangeCashTotal => (PenniesCoinChange * 0.01 +
                NickelsCoinChange * 0.05 +
                DimesCoinChange * 0.10 +
                QuartersCoinChange * 0.25 +
                HalfDollarsCoinChange * 0.50 +
                DollarsCoinChange * 1.00 +
                OnesBillChange * 1.00 +
                TwosBillChange * 2.00 +
                FiveBillChange * 5.00 +
                TensBillChange * 10.00 +
                TwentiesBillChange * 20.00 +
                FiftiesBillChange * 50.00 +
                HundredsBillChange * 100.00);

        /// <summary>
        /// Determines correct change denominations assigning the values to the
        /// properties defined below which are reflceted on the GUI.
        /// </summary>
        public void DetermineChangeDenominations()
        {
            HundredsBillChange = 0;
            FiftiesBillChange = 0;
            TwentiesBillChange = 0;
            TensBillChange = 0;
            FiveBillChange = 0;
            TwosBillChange = 0;
            OnesBillChange = 0;
            DollarsCoinChange = 0;
            HalfDollarsCoinChange = 0;
            QuartersCoinChange = 0;
            DimesCoinChange = 0;
            NickelsCoinChange = 0;
            PenniesCoinChange = 0;
            HundredsBillChange = ((int)Math.Floor(ChangeOwed / 100) > CashDrawer.Hundreds) ? CashDrawer.Hundreds : (int)Math.Floor(ChangeOwed / 100);
            FiftiesBillChange = ((int)Math.Floor(ChangeOwed / 50) > CashDrawer.Fifties) ? CashDrawer.Fifties : (int)Math.Floor(ChangeOwed / 50);
            TwentiesBillChange = ((int)Math.Floor(ChangeOwed / 25) > CashDrawer.Twenties) ? CashDrawer.Twenties : (int)Math.Floor(ChangeOwed / 25);
            TensBillChange = ((int)Math.Floor(ChangeOwed / 10) > CashDrawer.Tens) ? CashDrawer.Tens : (int)Math.Floor(ChangeOwed / 10);
            FiveBillChange = ((int)Math.Floor(ChangeOwed / 5) > CashDrawer.Fives) ? CashDrawer.Fives : (int)Math.Floor(ChangeOwed / 5);
            TwosBillChange = ((int)Math.Floor(ChangeOwed / 2) > CashDrawer.Twos) ? CashDrawer.Twos : (int)Math.Floor(ChangeOwed / 2);
            OnesBillChange = ((int)Math.Floor(ChangeOwed / 1) > CashDrawer.Ones) ? CashDrawer.Ones : (int)Math.Floor(ChangeOwed / 1);
            DollarsCoinChange = ((int)Math.Floor(ChangeOwed / 1) > CashDrawer.Dollars) ? CashDrawer.Dollars : (int)Math.Floor(ChangeOwed / 1);
            HalfDollarsCoinChange = ((int)Math.Floor(ChangeOwed / 0.5) > CashDrawer.HalfDollars) ? CashDrawer.HalfDollars : (int)Math.Floor(ChangeOwed / 0.5);
            QuartersCoinChange = ((int)Math.Floor(ChangeOwed / 0.25) > CashDrawer.Quarters) ? CashDrawer.Quarters : (int)Math.Floor(ChangeOwed / 0.25);
            DimesCoinChange = ((int)Math.Floor(ChangeOwed / 0.1) > CashDrawer.Dimes) ? CashDrawer.Dimes : (int)Math.Floor(ChangeOwed / 0.1);
            NickelsCoinChange = ((int)Math.Floor(ChangeOwed / 0.05) > CashDrawer.Nickels) ? CashDrawer.Nickels : (int)Math.Floor(ChangeOwed / 0.05);
            PenniesCoinChange = ((int)Math.Floor(ChangeOwed / 0.01) > CashDrawer.Pennies) ? CashDrawer.Pennies : (int)Math.Floor(ChangeOwed / 0.01);
        }

        /// <summary>
        /// Non-updating Change Owed value to be displayed on the GUI and Receipt
        /// </summary>
        public double ReceiptChangeOwed => ((CustomerCashTotal - Total) > 0) ? (CustomerCashTotal - Total) : 0;

        /// <summary>
        /// The amount of money the customer needs to add to satisfy payment
        /// </summary>
        public double AmountDue
        {
            get
            {
                return (Total - CustomerCashTotal) > 0 ? (Total - CustomerCashTotal) : 0;
            }
        }

        /// <summary>
        /// An updating changeowed that is used in determining cash change denominations
        /// </summary>
        public double ChangeOwed
        {
            get
            {
                if (CustomerCashTotal > Total)
                {
                    return Math.Round((CustomerCashTotal - Total) - ChangeCashTotal, 2);
                }
                else return 0;
            }
        }

        /// <summary>
        /// The number of pennies provided as change
        /// </summary>
        public int PenniesCoinChange
        {
            get => cpc.penny.ChangeQuantity;
            set
            {
                cpc.penny.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        /// <summary>
        /// The number of nickels provided as change
        /// </summary>
        public int NickelsCoinChange
        {
            get => cpc.nickel.ChangeQuantity;
            set
            {
                cpc.nickel.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        /// <summary>
        /// The number of dimes provided as change
        /// </summary>
        public int DimesCoinChange
        {
            get => cpc.dime.ChangeQuantity;
            set
            {
                cpc.dime.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        /// <summary>
        /// The number of quarters provided as change
        /// </summary>
        public int QuartersCoinChange
        {
            get => cpc.quarter.ChangeQuantity;
            set
            {
                cpc.quarter.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        /// <summary>
        /// The number of halfdollars provided as change
        /// </summary>
        public int HalfDollarsCoinChange
        {
            get => cpc.halfDollar.ChangeQuantity;
            set
            {
                cpc.halfDollar.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        /// <summary>
        /// The number of dollarcoins provided as change
        /// </summary>
        public int DollarsCoinChange
        {
            get => cpc.dollar.ChangeQuantity;
            set
            {
                cpc.dollar.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        /// <summary>
        /// The number of ones provided as change
        /// </summary>
        public int OnesBillChange
        {
            get => cpc.one.ChangeQuantity;
            set
            {
                cpc.one.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }
        /// <summary>
        /// The number of twos provided as change
        /// </summary>
        public int TwosBillChange
        {
            get => cpc.two.ChangeQuantity;
            set
            {
                cpc.two.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        /// <summary>
        /// The number of fives provided as change
        /// </summary>
        public int FiveBillChange
        {
            get => cpc.five.ChangeQuantity;
            set
            {
                cpc.five.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }
        /// <summary>
        /// The number of tens provided as change
        /// </summary>
        public int TensBillChange
        {
            get => cpc.ten.ChangeQuantity;
            set
            {
                cpc.ten.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        /// <summary>
        /// The number of twenties provided as change
        /// </summary>
        public int TwentiesBillChange
        {
            get => cpc.twenty.ChangeQuantity;
            set
            {
                cpc.twenty.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }
        /// <summary>
        /// The number of fifties provided as change
        /// </summary>
        public int FiftiesBillChange
        {
            get => cpc.fifty.ChangeQuantity;
            set
            {
                cpc.fifty.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        /// <summary>
        /// The number of hundreds provided as change
        /// </summary>
        public int HundredsBillChange
        {
            get => cpc.hundred.ChangeQuantity;
            set
            {
                cpc.hundred.ChangeQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }
        /// <summary>
        /// The number of pennies provided by customer
        /// </summary>
        public int PenniesCoinCustomer
        {
            get => cpc.penny.CustomerQuantity;
            set
            {
                cpc.penny.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesCoinCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }
        /// <summary>
        /// The number of nickels provided by customer
        /// </summary>

        public int NickelsCoinCustomer
        {
            get => cpc.nickel.CustomerQuantity;
            set
            {
                cpc.nickel.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsCoinCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }
        /// <summary>
        /// The number of dimes provided by customer
        /// </summary>
        public int DimesCoinCustomer
        {
            get => cpc.dime.CustomerQuantity;
            set
            {
                cpc.dime.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesCoinCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }

        /// <summary>
        /// The number of quarters provided by customer
        /// </summary>
        public int QuartersCoinCustomer
        {
            get => cpc.quarter.CustomerQuantity;
            set
            {
                cpc.quarter.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersCoinCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }
        /// <summary>
        /// The number of halfdollars provided by customer
        /// </summary>
        public int HalfDollarsCoinCustomer
        {
            get => cpc.halfDollar.CustomerQuantity;
            set
            {
                cpc.halfDollar.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsCoinCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }

        /// <summary>
        /// The number of dollars provided by customer
        /// </summary>
        public int DollarsCoinCustomer
        {
            get => cpc.dollar.CustomerQuantity;
            set
            {
                cpc.dollar.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarsCoinCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }
        /// <summary>
        /// The number of ones provided by customer
        /// </summary>
        public int OnesBillCustomer
        {
            get => cpc.one.CustomerQuantity;
            set
            {
                cpc.one.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesBillCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }

        /// <summary>
        /// The number of twos provided by customer
        /// </summary>
        public int TwosBillCustomer
        {
            get => cpc.two.CustomerQuantity;
            set
            {
                cpc.two.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosBillCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }
        /// <summary>
        /// The number of fives provided by customer
        /// </summary>
        public int FivesBillCustomer
        {
            get => cpc.five.CustomerQuantity;
            set
            {
                cpc.five.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesBillCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }

        /// <summary>
        /// The number of tens provided by customer
        /// </summary>
        public int TensBillCustomer
        {
            get => cpc.ten.CustomerQuantity;
            set
            {
                cpc.ten.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenBillCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }
        /// <summary>
        /// The number of twenties provided by customer
        /// </summary>
        public int TwentiesBillCustomer
        {
            get => cpc.twenty.CustomerQuantity;
            set
            {
                cpc.twenty.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesBillCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }

        /// <summary>
        /// The number of fifties provided by customer
        /// </summary>
        public int FiftiesBillCustomer
        {
            get => cpc.fifty.CustomerQuantity;
            set
            {
                cpc.fifty.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FifitesBillCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }
        /// <summary>
        /// The number of hundreds provided by customer
        /// </summary>
        public int HundredsBillCustomer
        {
            get => cpc.hundred.CustomerQuantity;
            set
            {
                cpc.hundred.CustomerQuantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsBillCustomer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReceiptChangeOwed"));
            }
        }


    }
}
