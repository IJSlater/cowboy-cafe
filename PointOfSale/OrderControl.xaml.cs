/*
* Ian Slater
* OrderControl
* Class to handle the entree ordering part of the POS system
*/
using System;
using CowboyCafe.Data;
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        private void AngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            AngryChicken ac = new AngryChicken();
            if (DataContext is Order order)
            {
                order.Add(ac);
            
            }
        }

        private void CowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            CowpokeChili cp = new CowpokeChili();
            
        }

        private void DakotaDoubleButton_Click(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger ddb = new DakotaDoubleBurger();
        }

        private void PecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            PecosPulledPork ppp = new PecosPulledPork();
        }

        private void RustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            RustlersRibs rr = new RustlersRibs();
        }

        private void TexasTripleButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger ttb = new TexasTripleBurger();
        }

        private void TrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            TrailBurger tb = new TrailBurger();
        }

        private void ChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries ccf = new ChiliCheeseFries();
        }

        private void CornDodgerButton_Click(object sender, RoutedEventArgs e)
        {
            CornDodgers cd = new CornDodgers();
        }

        private void PandeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            PanDeCampo pdc = new PanDeCampo();
        }

        private void JerkedSodeButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda js = new JerkedSoda();
        }

        private void CowboyCoffeButton_Click(object sender, RoutedEventArgs e)
        {
            CowboyCoffee cc = new CowboyCoffee();
        }

        private void TexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTea tt = new TexasTea();
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            Water w = new Water();
        }
    }
}
