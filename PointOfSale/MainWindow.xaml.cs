/*
* Ian Slater
* MainWindow
*Class to handle the overall visual interface for the POS
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order currentOrder = new Order();
            DataContext = currentOrder;
        }

        private void OrderControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void OrderControl_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void menuselectioncontrol_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
