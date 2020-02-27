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
            ticket.Items.Add(cp.ToString());
        }

        private void DakotaDoubleButton_Click(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger ddb = new DakotaDoubleBurger();
            ticket.Items.Add(ddb.ToString());
        }

        private void PecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            PecosPulledPork ppp = new PecosPulledPork();
            ticket.Items.Add(ppp.ToString());
        }

        private void RustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            RustlersRibs rr = new RustlersRibs();
            ticket.Items.Add(rr.ToString());
        }

        private void TexasTripleButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger ttb = new TexasTripleBurger();
            ticket.Items.Add(ttb.ToString());
        }

        private void TrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            TrailBurger tb = new TrailBurger();
            ticket.Items.Add(tb.ToString());
        }

        private void ChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries ccf = new ChiliCheeseFries();
            ticket.Items.Add(ccf.ToString());
        }

        private void CornDodgerButton_Click(object sender, RoutedEventArgs e)
        {
            CornDodgers cd = new CornDodgers();
            ticket.Items.Add(cd.ToString());
        }

        private void PandeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            PanDeCampo pdc = new PanDeCampo();
            ticket.Items.Add(pdc.ToString());
        }

        private void JerkedSodeButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda js = new JerkedSoda();
            ticket.Items.Add(js.ToString());
        }

        private void CowboyCoffeButton_Click(object sender, RoutedEventArgs e)
        {
            CowboyCoffee cc = new CowboyCoffee();
            ticket.Items.Add(cc.ToString());
        }

        private void TexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTea tt = new TexasTea();
            ticket.Items.Add(tt.ToString());
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            Water w = new Water();
            ticket.Items.Add(w.ToString());
        }
    }
}
