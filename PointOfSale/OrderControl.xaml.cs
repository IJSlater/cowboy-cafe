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
                ac.PropertyChanged += order.OnInstructionAdded;               
                MainWindow.Child = new CustomizationControl(ac);
            } 
           

        }

        private void CowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            CowpokeChili cp = new CowpokeChili();
            if (DataContext is Order order)
            {
                order.Add(cp);
                cp.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(cp);

            }

        }

        private void DakotaDoubleButton_Click(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger ddb = new DakotaDoubleBurger();
            if (DataContext is Order order)
            {
                order.Add(ddb);
                ddb.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(ddb);

            }
        }

        private void PecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            PecosPulledPork ppp = new PecosPulledPork();
            if (DataContext is Order order)
            {
                order.Add(ppp);
                ppp.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(ppp);

            }
        }

        private void RustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {

            RustlersRibs rr = new RustlersRibs();
            if (DataContext is Order order)
            {
                    order.Add(new RustlersRibs());
            }
        }

        private void TexasTripleButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger ttb = new TexasTripleBurger();
            if (DataContext is Order order)
            {
                order.Add(ttb);
                ttb.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(ttb);

            }
        }

        private void TrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            TrailBurger tb = new TrailBurger();
            if (DataContext is Order order)
            {
                order.Add(tb);
                tb.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(tb);

            }
        }

        private void ChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries ccf = new ChiliCheeseFries();
            if (DataContext is Order order)
            {
                order.Add(ccf);
                ccf.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(ccf);

            }
        }
        private void BakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            BakedBeans bb = new BakedBeans();
            if (DataContext is Order order)
            {
                order.Add(bb);
                bb.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(bb);

            }
        }

        private void CornDodgerButton_Click(object sender, RoutedEventArgs e)
        {
            CornDodgers cd = new CornDodgers();
            if (DataContext is Order order)
            {
                order.Add(cd);
                cd.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(cd);

            }
        }

        private void PandeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            PanDeCampo pdc = new PanDeCampo();
            if (DataContext is Order order)
            {
                order.Add(pdc);
                pdc.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(pdc);

            }
        }

        private void JerkedSodeButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda js = new JerkedSoda();
            if (DataContext is Order order)
            {
                order.Add(js);
                js.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(js);

            }
        }

        private void CowboyCoffeButton_Click(object sender, RoutedEventArgs e)
        {
            CowboyCoffee cc = new CowboyCoffee();
            if (DataContext is Order order)
            {
                order.Add(cc);
                cc.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(cc);

            }
        }

        private void TexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTea tt = new TexasTea();
            if (DataContext is Order order)
            {
                order.Add(tt);
                tt.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(tt);

            }
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            Water w = new Water();
            if (DataContext is Order order)
            {
                order.Add(w);
                w.PropertyChanged += order.OnInstructionAdded;
                MainWindow.Child = new CustomizationControl(w);

            }
        }

        public void SwapScreen()
        {
            MainWindow.Child = new OrderControl();
        }


    }
}
