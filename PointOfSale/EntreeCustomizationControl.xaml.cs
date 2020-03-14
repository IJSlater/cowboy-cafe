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
using System.ComponentModel;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeCustomizationControl.xaml
    /// </summary>
    public partial class EntreeCustomizationControl : UserControl
    {

        public EntreeCustomizationControl(IOrderItem item)
        {
            InitializeComponent();
            //DataContext = (AngryChicken)item;

            if (item is AngryChicken ac)
            {
                DataContext = ac;
                BasicsControll();
            }
            else if (item is CowpokeChili cp)
            {
                DataContext = cp;

            }
            else if (item is DakotaDoubleBurger ddb)
            {
                DataContext = ddb;
                //AngryChickenControll();
            }
            else if (item is PecosPulledPork ppp)
            {
                DataContext = ppp;
                BasicsControll();
            }
            else if (item is RustlersRibs rr)
            {

                //border.Child = new OrderControl();
                //DataContext = rr;
                //AngryChickenControll();
            }
            else if (item is TexasTripleBurger ttb)
            {
                DataContext = ttb;
                //AngryChickenControll();
            }
            else if (item is TrailBurger tb)
            {
                DataContext = tb;
                //AngryChickenControll();
            }
            else
            {
                throw new NotImplementedException("Menu Item not accounted for");
            }



        }
        private void BasicsControll()
        {
            CheckBox Bread = new CheckBox();
            Bread.Content = "Bread";
            var BreadBinding = new Binding() 
            {
                Source = DataContext,
                Path = new PropertyPath("Bread"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Bread, CheckBox.IsCheckedProperty, BreadBinding);

            CheckBox Pickle = new CheckBox();
            Pickle.Content = "Pickle";
            var PickleBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Pickle"),
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
            };
            BindingOperations.SetBinding(Pickle, CheckBox.IsCheckedProperty, PickleBinding);

            LeftBox.Items.Add(Bread);
            RightBox.Items.Add(Pickle);


        }
        private void CowPokeChiliControll()
        { }
        private void DakotaDoubleControll()
        { }
        private void PecosPulledPorkControll()
        { }
        private void RustlersRibsControll()
        { }
        private void TexasTripleControll()
        { }
        private void TrailBurgerControll()
        { }



        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ((CheckBox)sender).GetBindingExpression(CheckBox.IsCheckedProperty).UpdateTarget();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            border.Child = new OrderControl();
        }
    }
}
