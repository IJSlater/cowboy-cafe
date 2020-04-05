/*
* Ian Slater
* MenuSelectionControl
* Parent Class for all Items that will go on an item 
*/
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MenuSelectionControl : UserControl
    {
        public MenuSelectionControl()
        {
            InitializeComponent();
        }

        private void ItemSelectionButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelOrderButon_Click(object sender, RoutedEventArgs e)
        {
            MainWindow parent = ((MainWindow)((Grid)Parent).Parent);
            Order.OrderNumber--;
            parent.DataContext = new Order();
            if (parent.ordercontrol.MainWindow.Child is OrderControl)
                return;
            parent.ordercontrol.SwapScreen(null);



        }

        private void CompleteOrderButon_Click(object sender, RoutedEventArgs e)
        {
            MainWindow parent = ((MainWindow)((Grid)Parent).Parent);
            Order a = (Order)DataContext;
            Array x = (Array)a.Items;
            if (x.Length == 0)
                return;
            parent.ordercontrol.SwapScreen(new TransactionControll());
        }
    }
}
