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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashControll.xaml
    /// </summary>
    public partial class CashControll : UserControl
    {
        public CashControll()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var a = (CashRegisterModelView)DataContext;
            double total = a.TotalValue;


            //public List<typeof(Pennoes)> = new List<T>{Pennies,};

}
    }
}
