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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ConiControll.xaml
    /// </summary>
    public partial class CoinControll : UserControl
    {
        public CoinControll()
        {
            InitializeComponent();
            //denominationTextBox.Text = Denomination.ToString();
        }



        public static readonly DependencyProperty DenominationProperty = DependencyProperty.Register(
    "Denomination", typeof(Coins), typeof(CoinControll), new PropertyMetadata(Coins.Penny)
    );

        public Coins Denomination
        {

            get
            {
                return (Coins)GetValue(DenominationProperty);
            }
            set
            {
                SetValue(DenominationProperty, value);
            }
        }


        public static readonly DependencyProperty QuantityProperty = DependencyProperty.Register(
"Quantity", typeof(int), typeof(CoinControll), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
);

        public int Quantity
        {

            get
            {
                return (int)GetValue(QuantityProperty);
            }
            set
            {
                SetValue(QuantityProperty, value);
            }
        }


        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;

        }

        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;

        }




    }
}
