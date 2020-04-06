using System;
using System.Collections.Generic;
using System.Text;
using CashRegister;
using System.ComponentModel;

namespace PointOfSale
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

        private int pennies = 0;
        public int Pennies
        {
            get =>  pennies;
            set
            {
                if (pennies + value < 0)
                    return;
                pennies += value;


            }
        }

        private int nickles = 0;
        public int Nickles
        {
            get => nickles;
            set
            {
                if (nickles == value || value < 0)
                    return;
                var quantity = value - nickles;
                if (quantity > 0)
                    pennies += quantity;
                else
                    pennies -= quantity;
            }
        }

        private int dimes = 0;
        public int Dimes
        {
            get => dimes;
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
        private int quarters = 0;
        public int Quarters
        {
            get => quarters;
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
        private int halfdollars = 0;
        public int HalfDollers
        {
            get => halfdollars;
            set
            {
                halfdollars++;
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
        private int dollars = 0;
        public int Dollars
        {
            get => dollars;
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
        private int ones = 0;
        public int Ones
        {
            get => ones;
            set
            {
                
                if (drawer.Ones == value || value < 0)
                    return;
                var quantity = value - drawer.Ones;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.One, quantity);
                    ones += quantity;
                }
                else
                {
                    drawer.RemoveBill(Bills.One, -quantity);
                    ones -= quantity;
                }
                InvokePropertyChanger("Ones");
            }
        }
        private int twos = 0;
        public int Twos
        {
            get => twos;
            set
            {
                
                if (drawer.Twos == value || value < 0)
                    return;
                var quantity = value - drawer.Twos;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Two, quantity);
                    twos += quantity;
                }
                else
                {
                    drawer.RemoveBill(Bills.Two, -quantity);
                    twos += quantity;
                }
                InvokePropertyChanger("Twos");
            }
        }

        private int fives = 0;
        public int Fives
        {
            get => fives;
            set
            {
                
                if (drawer.Fives == value || value < 0)
                    return;
                var quantity = value - drawer.Fives;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Five, quantity);
                    fives += quantity;
                }
                else
                {
                    drawer.RemoveBill(Bills.Five, -quantity);
                    fives -= quantity;
                }
                InvokePropertyChanger("Fives");
            }
        }
        private int tens = 0;
        public int Tens
        {
            get => tens;
            set
            {
                
                if (drawer.Tens == value || value < 0)
                    return;
                var quantity = value - drawer.Tens;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Ten, quantity);
                    tens += quantity;
                }
                else
                {
                    drawer.RemoveBill(Bills.Ten, -quantity);
                    tens -= quantity;
                }
                InvokePropertyChanger("Tens");
            }
        }
        private int twenties = 0;
        public int Twenties
        {
            get => twenties;
            set
            {
                if (drawer.Twenties == value || value < 0)
                    return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Twenty, quantity);
                    twenties += quantity;
                }
                else
                {
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                    twenties -= quantity;
                }
                InvokePropertyChanger("Twenties");
            }
        }
        private int fifties = 0;
        public int Fifties
        {
            get => fifties;
            set
            {
                if (drawer.Fifties == value || value < 0)
                    return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Fifty, quantity);
                    fifties += quantity;
                }
                else
                {
                    fifties -= quantity;
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                }
                InvokePropertyChanger("Fifties");
            }
        }

        private int hundreds = 0;
        public int Hundreds
        {
            get => hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0)
                    return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Hundred, quantity);
                    hundreds += quantity;
                }
                else
                {
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                    hundreds -= quantity;
                }
                    InvokePropertyChanger("Hundreds");
            }
        }



    }
}
