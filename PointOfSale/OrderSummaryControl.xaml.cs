/*
* Ian Slater
* OrderSummaryControl
* Class to handle the showing of the ticket to the cashier 
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
            
        }

        public void RemoveItemClicked(object sender, RoutedEventArgs e)
        {
            ticket.SelectedItem = -1;

            if (DataContext is Order order)
            {
                
                ((Order)DataContext).Remove((IOrderItem)ticket.SelectedItem);
            }


        }


    }
}
