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
using CashRegister;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for RegisterControll.xaml
    /// </summary>
    public partial class RegisterControll : UserControl
    {
        private CashDrawer drawer = new CashDrawer();


        public int Pennies{ get; set; }
        public int Nickles { get; set; }
        public int Dimes { get; set; }
        private int Quarters { get; set; }
        private int HalfDollars { get; set; }
        private int Dollars { get; set; }
        private int Ones { get; set; }
        private int Twos { get; set; }
        public int Fives { get; set; }
        private int Tens { get; set; }
        private int Twenties { get; set; }
        private int Fifties { get; set; }
        private int Hundreds { get; set; }

        public Double Total 
        {
            get 
            {
                return Pennies/100 + (Nickles*5)/100 + (Dimes*10)/100 + (Quarters*25)/100 + (HalfDollars*50)/100 + Dollars + Ones + Twos*2 + Fives*5+Tens*10+Twenties*20 + Fifties*50 + Hundreds*100;
            }
        }
        public RegisterControll()
        {
            InitializeComponent();
            Order order = (Order)DataContext;
            var a =Parent;

        }

        private void Cash_Print(double input)
        {
            ReceiptPrinter rp = new ReceiptPrinter();
            string receipt = "\n";
            Order order = (Order)DataContext;
            receipt += DateTime.Now + "\tOrder# " + Order.OrderNumber + "\n";
            foreach (IOrderItem item in order.Items)
            {
                receipt += item.ToString() + "\n";
                foreach (string instruction in item.SpecialInstructions)
                {
                    receipt += "\t" + instruction + "\n";
                }
            }
            receipt += "-------------------------------\n";
            receipt += "Payment Method: Cash\n";
            receipt += "Total: " + order.Total.ToString("C")+"\n";
            receipt += "Payed: " + input.ToString("C") + "\n";
            receipt += "Change: " + (input-order.Total).ToString("C") + "\n";

            rp.Print(receipt);


        }

        public void Clear_Order()
        {
            Pennies = 0;
            PenniesText.Text = Pennies.ToString();
            Nickles = 0;
            NicklesText.Text = Nickles.ToString();
            Dimes = 0;
            DimesText.Text = Dimes.ToString();
            Quarters = 0;
            QuartersText.Text = Quarters.ToString();
            HalfDollars = 0;
            HalfDollarsText.Text = HalfDollars.ToString();
            Dollars = 0;
            DollarsText.Text = Dollars.ToString();
            Ones = 0;
            OnesText.Text = Ones.ToString();
            Twos = 0;
            TwosText.Text = Twos.ToString();
            Fives = 0;
            FivesText.Text = Fives.ToString();
            Tens = 0;
            TensText.Text = Tens.ToString();
            Twenties = 0;
            TwentiesText.Text = Twenties.ToString();
            Fifties = 0;
            FiftiesText.Text = Fifties.ToString();
            Hundreds = 0;
            HundredsText.Text = Hundreds.ToString();

            TotalBox.Text = 0.00.ToString("C");

        }

        private void Pennies_minus(object sender, RoutedEventArgs e)
        {
            if (Pennies - 1 < 0)
                return;
            Pennies--;
            PenniesText.Text = Pennies.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Pennies_add(object sender, RoutedEventArgs e)
        {
            Pennies++;
            PenniesText.Text = Pennies.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Nickles_add(object sender, RoutedEventArgs e)
        {
            Nickles++;
            NicklesText.Text = Nickles.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Nickles_minus(object sender, RoutedEventArgs e)
        {
            
            if (Nickles - 1 < 0)
                return;
            Nickles--;
            NicklesText.Text = Nickles.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Dimes_add(object sender, RoutedEventArgs e)
        {
            Dimes++;
            DimesText.Text = Dimes.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Dimes_minus(object sender, RoutedEventArgs e)
        {

            if (Dimes - 1 < 0)
                return;
            Dimes--;
            DimesText.Text = Dimes.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Quarters_add(object sender, RoutedEventArgs e)
        {
            Quarters++;
            QuartersText.Text = Quarters.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Quarters_minus(object sender, RoutedEventArgs e)
        {

            if (Quarters - 1 < 0)
                return;
            Quarters--;
            QuartersText.Text = Quarters.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void HalfDollars_add(object sender, RoutedEventArgs e)
        {
            HalfDollars++;
            HalfDollarsText.Text = HalfDollars.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void HalfDollars_minus(object sender, RoutedEventArgs e)
        {

            if (HalfDollars - 1 < 0)
                return;
            HalfDollars--;
            HalfDollarsText.Text = HalfDollars.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Dollars_add(object sender, RoutedEventArgs e)
        {
            Dollars++;
            DollarsText.Text = Dollars.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Dollars_minus(object sender, RoutedEventArgs e)
        {

            if (Dollars - 1 < 0)
                return;
            Dollars--;
            DollarsText.Text = Dollars.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Ones_add(object sender, RoutedEventArgs e)
        {
            Ones++;
            OnesText.Text = Ones.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Ones_minus(object sender, RoutedEventArgs e)
        {

            if (Ones - 1 < 0)
                return;
            Ones--;
            OnesText.Text = Ones.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Twos_add(object sender, RoutedEventArgs e)
        {
            Twos++;
            TwosText.Text = Twos.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Twos_minus(object sender, RoutedEventArgs e)
        {

            if (Twos - 1 < 0)
                return;
            Twos--;
            TwosText.Text = Twos.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Fives_add(object sender, RoutedEventArgs e)
        {
            Fives++;
            FivesText.Text = Fives.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Fives_minus(object sender, RoutedEventArgs e)
        {

            if (Fives - 1 < 0)
                return;
            Fives--;
            FivesText.Text = Fives.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Tens_add(object sender, RoutedEventArgs e)
        {
            Tens++;
            TensText.Text = Tens.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Tens_minus(object sender, RoutedEventArgs e)
        {

            if (Tens - 1 < 0)
                return;
            Tens--;
            TensText.Text = Tens.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Twenties_add(object sender, RoutedEventArgs e)
        {
            Twenties++;
            TwentiesText.Text = Twenties.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Twenties_minus(object sender, RoutedEventArgs e)
        {

            if (Twenties - 1 < 0)
                return;
            Twenties--;
            TwentiesText.Text = Twenties.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Fifties_add(object sender, RoutedEventArgs e)
        {
            Fifties++;
            FiftiesText.Text = Fifties.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Fifties_minus(object sender, RoutedEventArgs e)
        {

            if (Fifties - 1 < 0)
                return;
            Fifties--;
            FiftiesText.Text = Fifties.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Hundreds_add(object sender, RoutedEventArgs e)
        {
            Hundreds++;
            HundredsText.Text = Hundreds.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Hundreds_minus(object sender, RoutedEventArgs e)
        {

            if (Hundreds - 1 < 0)
                return;
            Hundreds--;
            HundredsText.Text = Hundreds.ToString();
            TotalBox.Text = Total.ToString("C");
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {

            Order order = (Order)DataContext;
            double change = Total - order.Total;

            if (Pennies != 0)
                drawer.AddCoin(Coins.Penny, Pennies);
            else if (Nickles != 0)
                drawer.AddCoin(Coins.Nickel, Nickles);
            else if (Dimes != 0)
                drawer.AddCoin(Coins.Dime, Dimes);
            else if (Quarters != 0)
                drawer.AddCoin(Coins.Quarter, Quarters);
            else if (HalfDollars != 0)
                drawer.AddCoin(Coins.HalfDollar, HalfDollars);
            else if (Dollars != 0)
                drawer.AddCoin(Coins.Dollar, Dollars);
            else if (Ones != 0)
                drawer.AddBill(Bills.One, Ones);
            else if (Twos != 0)
                drawer.AddBill(Bills.Two, Twos);
            else if (Fives != 0)
                drawer.AddBill(Bills.Five, Fives);
            else if (Tens != 0)
                drawer.AddBill(Bills.Ten, Tens);
            else if (Twenties != 0)
                drawer.AddBill(Bills.Twenty, Twenties);
            else if (Fifties != 0)
                drawer.AddBill(Bills.Fifty, Fifties);
            else if (Hundreds != 0)
                drawer.AddBill(Bills.Hundred, Hundreds);



            if (change < 0)
            {
                MessageBox.Show("Insuficient Funds");
                return;
            }
            else if (change > drawer.TotalValue)
            {
                MessageBox.Show("Error Not enough money to break this bill");
                return;
            }
            else if (change == 0)
            {
                MessageBox.Show("Sucess");
                OrderControl parent = ((OrderControl)((Border)Parent).Parent);
                MainWindow main = (MainWindow)((Grid)(parent.Parent)).Parent;
                main.DataContext = new Order();

            }
            else
            {
                MessageBox.Show("Change Due: " + change.ToString("C"));
                while (change >= 0.009999999999999999999999999999999999999)
                {
                    if (change - 100 > 0 && drawer.Hundreds > 0)
                    {
                        drawer.RemoveBill(Bills.Hundred, 1);
                        change -= 100;
                    }
                    if (change - 50 > 0 && drawer.Fifties > 0)
                    {
                        drawer.RemoveBill(Bills.Fifty, 1);
                        change -= 50;
                    }
                    if (change - 20 > 0 && drawer.Twenties > 0)
                    {
                        drawer.RemoveBill(Bills.Twenty, 1);
                        change -= 20;
                    }
                    if (change - 10 > 0 && drawer.Tens > 0)
                    {
                        drawer.RemoveBill(Bills.Ten, 1);
                        change -= 10;
                    }
                    if (change - 5 > 0 && drawer.Fives > 0)
                    {
                        drawer.RemoveBill(Bills.Five, 1);
                        change -= 5;
                    }
                    if (change - 1 > 0 && drawer.Ones > 0)
                    {
                        drawer.RemoveBill(Bills.One, 1);
                        change -= 1;
                    }
                    if (change - 1 > 0 && drawer.Dollars > 0)
                    {
                        drawer.RemoveCoin(Coins.Dollar, 1);
                        change -= 1;
                    }
                    if (change - .50 > 0 && drawer.HalfDollars > 0)
                    {
                        drawer.RemoveCoin(Coins.HalfDollar, 1);
                        change -= .50;
                    }
                    if (change - .25 > 0 && drawer.Quarters > 0)
                    {
                        drawer.RemoveCoin(Coins.Quarter, 1);
                        change -= .25;
                    }
                    if (change - .10 > 0 && drawer.Dimes > 0)
                    {
                        drawer.RemoveCoin(Coins.Dime, 1);
                        change -= .10;
                    }
                    if (change - .05 > 0 && drawer.Nickels > 0)
                    {
                        drawer.RemoveCoin(Coins.Nickel, 1);
                        change -= .05;
                    }
                    if (change - .01 > 0 && drawer.Pennies > 0)
                    {
                        drawer.RemoveCoin(Coins.Penny, 1);
                        change -= .01;
                    }

                }

                OrderControl parent = (OrderControl)((Border)Parent).Parent;
                MainWindow main = (MainWindow)((Grid)(parent.Parent)).Parent;
                Cash_Print(Total);
                main.DataContext = new Order();
                parent.SwapScreen(null);

            }
            
           

        }
    }
}
