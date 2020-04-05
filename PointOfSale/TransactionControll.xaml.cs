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
using CowboyCafe.Data;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControll.xaml
    /// </summary>
    public partial class TransactionControll : UserControl
    {
        public TransactionControll()
        {
            InitializeComponent();
            uint x = Order.OrderNumber;
            OrderNumberTextBox.Text = x.ToString();


        }

        private void Cancel_Clicked(object sender, RoutedEventArgs e)
        {
            OrderControl parent = (OrderControl)((Border)Parent).Parent;
            parent.SwapScreen(null);
        }

        private void CreditCard_Clicked(object sender, RoutedEventArgs e)
        {
            CardTerminal ct = new CardTerminal();
            ResultCode result = ResultCode.UnknownErrror;
            string name = "Unknown Error";
            try
            {
                 result = ct.ProcessTransaction(((Order)DataContext).Total);
                 name = Enum.GetName(typeof(ResultCode), result);
            }
            catch (DrawerOverdrawException)
            {
                MessageBox.Show("Card Over Drawn");
            }
            if (result != ResultCode.Success)
            {
                MessageBox.Show("Error " + name);
                return;
            }
            else if (result == ResultCode.Success)
            {
                MessageBox.Show("Error " + name);
                OrderControl parent = ((OrderControl)((Border)Parent).Parent);
                MainWindow main = (MainWindow)((Grid)(parent.Parent)).Parent;
                main.DataContext = new Order();
                parent.SwapScreen(null);
            }


        }
        private void Cash_Clicked(object sender, RoutedEventArgs e)
        {


        }

    }
}
