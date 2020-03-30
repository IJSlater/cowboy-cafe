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

        /// <summary>
        /// finds the current item and remvoes it from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RemoveItemClicked(object sender, RoutedEventArgs e)
        {
            

            if (DataContext is Order order)
            {
                IOrderItem i = (IOrderItem)((Button)e.Source).DataContext;
                ((Order)DataContext).Remove((IOrderItem)i);
            }


        }
        /// <summary>
        /// pulls up the customization screen of the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemName_PreviewMouseDown(object sender, MouseEventArgs e)
        {

            
            
            MainWindow a = (MainWindow)((Grid)this.Parent).Parent;
            if (((TextBlock)e.Source).DataContext is IOrderItem item)
            {
                a.ordercontrol.MainWindow.Child = new CustomizationControl(item);
            }
        }
    }
}
