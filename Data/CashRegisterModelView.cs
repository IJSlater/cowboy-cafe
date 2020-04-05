using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace MVVMDataBinding
{
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// event changed handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// cash drawer for the project
        /// </summary>
        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// public getter for private drawer variable
        /// </summary>
        public double TotalValue => drawer.TotalValue;
        /// <summary>
        /// helper method for invoking property changed
        /// </summary>
        /// <param name="changed"></param>
        void InvokePropertyChanger(string changed)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(changed));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }


        public int Pennies
        {
            get => drawer.Pennies;
            set
            {
                if (drawer.Pennies == value || value < 0)
                    return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0)
                    drawer.AddCoin(Coins.Penny, quantity);
                else
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanger("Pennies");
            }
        }

        public int Nickles
        {
            get => drawer.Nickels;
            set
            {
                if (drawer.Nickels == value || value < 0)
                    return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0)
                    drawer.AddCoin(Coins.Nickel, quantity);
                else
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanger("Nickels");
            }
        }

        public int Dimes
        {
            get => drawer.Dimes;
            set
            {
                if (drawer.Dimes == value || value < 0)
                    return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0)
                    drawer.AddCoin(Coins.Dime, quantity);
                else
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanger("Dimes");
            }
        }

        public int Quarters
        {
            get => drawer.Quarters;
            set
            {
                if (drawer.Quarters == value || value < 0)
                    return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0)
                    drawer.AddCoin(Coins.Quarter, quantity);
                else
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanger("Quarters");
            }
        }

        public int HalfDollers
        {
            get => drawer.HalfDollars;
            set
            {
                if (drawer.HalfDollars == value || value < 0)
                    return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0)
                    drawer.AddCoin(Coins.HalfDollar, quantity);
                else
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanger("HalfDollars");
            }
        }

        public int Dollars
        {
            get => drawer.Dollars;
            set
            {
                if (drawer.Dollars == value || value < 0)
                    return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0)
                    drawer.AddCoin(Coins.Dollar, quantity);
                else
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanger("Dollars");
            }
        }

        public int Ones
        {
            get => drawer.Ones;
            set
            {
                if (drawer.Ones == value || value < 0)
                    return;
                var quantity = value - drawer.Ones;
                if (quantity > 0)
                    drawer.AddBill(Bills.One, quantity);
                else
                    drawer.RemoveBill(Bills.One, -quantity);
                InvokePropertyChanger("Ones");
            }
        }

        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (drawer.Twos == value || value < 0)
                    return;
                var quantity = value - drawer.Twos;
                if (quantity > 0)
                    drawer.AddBill(Bills.Two, quantity);
                else
                    drawer.RemoveBill(Bills.Two, -quantity);
                InvokePropertyChanger("Twos");
            }
        }


        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (drawer.Fives == value || value < 0)
                    return;
                var quantity = value - drawer.Fives;
                if (quantity > 0)
                    drawer.AddBill(Bills.Five, quantity);
                else
                    drawer.RemoveBill(Bills.Five, -quantity);
                InvokePropertyChanger("Fives");
            }
        }

        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (drawer.Tens == value || value < 0)
                    return;
                var quantity = value - drawer.Tens;
                if (quantity > 0)
                    drawer.AddBill(Bills.Ten, quantity);
                else
                    drawer.RemoveBill(Bills.Ten, -quantity);
                InvokePropertyChanger("Tens");
            }
        }

        public int Twenties
        {
            get => drawer.Twenties;
            set
            {
                if (drawer.Twenties == value || value < 0)
                    return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0)
                    drawer.AddBill(Bills.Twenty, quantity);
                else
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                InvokePropertyChanger("Twenties");
            }
        }
        public int Fifties
        {
            get => drawer.Fifties;
            set
            {
                if (drawer.Fifties == value || value < 0)
                    return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0)
                    drawer.AddBill(Bills.Fifty, quantity);
                else
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                InvokePropertyChanger("Fifties");
            }
        }

        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0)
                    return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0)
                    drawer.AddBill(Bills.Hundred, quantity);
                else
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                InvokePropertyChanger("Hundreds");
            }
        }





    }
}
