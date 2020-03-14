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
                ac.PropertyChanged += order.OnInstructionAdded;
                order.Add(ac);

            } 
            MainWindow.Child = new EntreeCustomizationControl(ac);
            //DataContext = order;
            //order.Add(ac);
        }

        private void CowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            CowpokeChili cp = new CowpokeChili();
            if (DataContext is Order order)
            {
                order.Add(cp);

            }

        }

        private void DakotaDoubleButton_Click(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger ddb = new DakotaDoubleBurger();
            if (DataContext is Order order)
            {
                order.Add(ddb);

            }
        }

        private void PecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            PecosPulledPork ppp = new PecosPulledPork();
            if (DataContext is Order order)
            {
                order.Add(ppp);

            }
        }

        private void RustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            RustlersRibs rr = new RustlersRibs();
            if (DataContext is Order order)
            {
                order.Add(rr);

            }
        }

        private void TexasTripleButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger ttb = new TexasTripleBurger();
            if (DataContext is Order order)
            {
                order.Add(ttb);

            }
        }

        private void TrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            TrailBurger tb = new TrailBurger();
            if (DataContext is Order order)
            {
                order.Add(tb);

            }
        }

        private void ChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries ccf = new ChiliCheeseFries();
            if (DataContext is Order order)
            {
                order.Add(ccf);

            }
        }

        private void CornDodgerButton_Click(object sender, RoutedEventArgs e)
        {
            CornDodgers cd = new CornDodgers();
            if (DataContext is Order order)
            {
                order.Add(cd);

            }
        }

        private void PandeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            PanDeCampo pdc = new PanDeCampo();
            if (DataContext is Order order)
            {
                order.Add(pdc);

            }
        }

        private void JerkedSodeButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda js = new JerkedSoda();
            if (DataContext is Order order)
            {
                order.Add(js);

            }
        }

        private void CowboyCoffeButton_Click(object sender, RoutedEventArgs e)
        {
            CowboyCoffee cc = new CowboyCoffee();
            if (DataContext is Order order)
            {
                order.Add(cc);

            }
        }

        private void TexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTea tt = new TexasTea();
            if (DataContext is Order order)
            {
                order.Add(tt);

            }
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            Water w = new Water();
            if (DataContext is Order order)
            {
                order.Add(w);

            }
        }
    }
}
