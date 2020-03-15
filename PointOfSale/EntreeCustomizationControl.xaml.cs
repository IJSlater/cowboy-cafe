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
            if (item is Entree)
            {
                if (item is AngryChicken ac)
                {
                    DataContext = ac;
                    BasicsControll();
                }
                else if (item is CowpokeChili cp)
                {
                    DataContext = cp;
                    CowPokeChilliControll();

                }
                else if (item is DakotaDoubleBurger ddb)
                {
                    DataContext = ddb;
                    BurgerBasicsControll();
                    DoubleBurgerControll();
                }
                else if (item is PecosPulledPork ppp)
                {
                    DataContext = ppp;
                    BasicsControll();
                }
                else if (item is TexasTripleBurger ttb)
                {
                    DataContext = ttb;
                    BurgerBasicsControll();
                    DoubleBurgerControll();
                    TripleBurgerControll();

                }
                else if (item is TrailBurger tb)
                {
                    DataContext = tb;
                    BurgerBasicsControll();
                }
                else
                {
                    throw new NotImplementedException("Menu Item not accounted for");
                }
            }
            else if (item is Drink)
            {
                if (item is JerkedSoda js)
                {
                    DataContext = js;
                    JerkedSodaControll();
                }
                else if (item is CowboyCoffee cb)
                {
                    DataContext = cb;
                    CowboyCoffeeControll();

                }
                else if (item is TexasTea tt)
                {
                    DataContext = tt;
                    TexasTeaControll();
                }
                else if (item is Water w)
                {
                    DataContext = w;
                    WaterControll();


                }


            }
            else if (item is Side)
            {
               // if(item is )
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
            Bread.HorizontalAlignment = HorizontalAlignment.Right;
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

        private void BurgerBasicsControll()
        {
            CheckBox Bun = new CheckBox();
            Bun.Content = "Bun";
            Bun.HorizontalAlignment = HorizontalAlignment.Right;
            var BunBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Bun"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Bun, CheckBox.IsCheckedProperty, BunBinding);

            CheckBox Ketchup = new CheckBox();
            Ketchup.Content = "Ketchup";
            Ketchup.HorizontalAlignment = HorizontalAlignment.Right;
            var KetchupBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Ketchup"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Ketchup, CheckBox.IsCheckedProperty, KetchupBinding);

            CheckBox Mustard = new CheckBox();
            Mustard.Content = "Mustard";
            Mustard.HorizontalAlignment = HorizontalAlignment.Right;
            var MustardBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Mustard"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Mustard, CheckBox.IsCheckedProperty, MustardBinding);

            CheckBox Pickle = new CheckBox();
            Pickle.Content = "Pickle";
            Pickle.HorizontalAlignment = HorizontalAlignment.Right;
            var PickleBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Pickle"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Pickle, CheckBox.IsCheckedProperty, PickleBinding);

            CheckBox Cheese = new CheckBox();
            Cheese.Content = "Cheese";
            Cheese.HorizontalAlignment = HorizontalAlignment.Right;
            var CheeseBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Cheese"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Cheese, CheckBox.IsCheckedProperty, CheeseBinding);
            
            LeftBox.Items.Add(Bun);
            RightBox.Items.Add(Pickle);
            LeftBox.Items.Add(Ketchup);
            RightBox.Items.Add(Mustard);
            LeftBox.Items.Add(Cheese);

        }

        private void DoubleBurgerControll()
        {
            CheckBox Tomato = new CheckBox();
            Tomato.Content = "Tomato";
            Tomato.HorizontalAlignment = HorizontalAlignment.Right;
            var TomatoBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Tomato"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Tomato, CheckBox.IsCheckedProperty, TomatoBinding);

            CheckBox Lettuce = new CheckBox();
            Lettuce.Content = "Lettuce";
            Lettuce.HorizontalAlignment = HorizontalAlignment.Right;
            var LettuceBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Lettuce"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Lettuce, CheckBox.IsCheckedProperty, LettuceBinding);

            CheckBox Mayo = new CheckBox();
            Mayo.Content = "Mayo";
            Mayo.HorizontalAlignment = HorizontalAlignment.Right;
            var MayoBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Mayo"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Mayo, CheckBox.IsCheckedProperty, MayoBinding);

            RightBox.Items.Add(Tomato);
            LeftBox.Items.Add(Lettuce);
            RightBox.Items.Add(Mayo);

        }
        private void TripleBurgerControll()
        {
            CheckBox Bacon = new CheckBox();
            Bacon.Content = "Bacon";
            Bacon.HorizontalAlignment = HorizontalAlignment.Right;
            var BaconBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Bacon"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Bacon, CheckBox.IsCheckedProperty, BaconBinding);

            CheckBox Egg = new CheckBox();
            Egg.Content = "Egg";
            Egg.HorizontalAlignment = HorizontalAlignment.Right;
            var EggBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Egg"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Egg, CheckBox.IsCheckedProperty, EggBinding);
            RightBox.Items.Add(Bacon);
            LeftBox.Items.Add(Egg);

        }

        private void CowPokeChilliControll()
        {
            CheckBox Cheese = new CheckBox();
            Cheese.Content = "Cheese";
            Cheese.HorizontalAlignment = HorizontalAlignment.Right;
            var CheeseBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Cheese"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };

            BindingOperations.SetBinding(Cheese, CheckBox.IsCheckedProperty, CheeseBinding);

            CheckBox SourCream = new CheckBox();
            SourCream.Content = "SourCream";
            SourCream.HorizontalAlignment = HorizontalAlignment.Right;
            var SourCreamBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("SourCream"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(SourCream, CheckBox.IsCheckedProperty, SourCreamBinding);

            CheckBox GreenOnions = new CheckBox();
            GreenOnions.Content = "GreenOnions";
            GreenOnions.HorizontalAlignment = HorizontalAlignment.Right;
            var GreenOnionsBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("GreenOnions"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(GreenOnions, CheckBox.IsCheckedProperty, GreenOnionsBinding);

            CheckBox TortillaStrips = new CheckBox();
            TortillaStrips.Content = "TortillaStrips";
            TortillaStrips.HorizontalAlignment = HorizontalAlignment.Right;
            var TortillaStripsBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("TortillaStrips"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(TortillaStrips, CheckBox.IsCheckedProperty, TortillaStripsBinding);

            LeftBox.Items.Add(Cheese);
            RightBox.Items.Add(SourCream);
            LeftBox.Items.Add(GreenOnions);
            RightBox.Items.Add(TortillaStrips);
        }
        private void IceControll()
        {
            CheckBox Ice = new CheckBox();
            Ice.Content = "Ice";
            Ice.HorizontalAlignment = HorizontalAlignment.Right;
            var IceBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Ice"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };

            BindingOperations.SetBinding(Ice, CheckBox.IsCheckedProperty, IceBinding);
            RightBox.Items.Add(Ice);
        }
        private void LemonControll()
        {
            CheckBox Lemon = new CheckBox();
            Lemon.Content = "Lemon";
            Lemon.HorizontalAlignment = HorizontalAlignment.Right;
            var LemonBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Lemon"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };
            BindingOperations.SetBinding(Lemon, CheckBox.IsCheckedProperty, LemonBinding);
            RightBox.Items.Add(Lemon);
        }
        private void SweetControll()
        {
            CheckBox Sweet = new CheckBox();
            Sweet.Content = "Sweet";
            Sweet.HorizontalAlignment = HorizontalAlignment.Right;
            var SweetBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Sweet"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };

            BindingOperations.SetBinding(Sweet, CheckBox.IsCheckedProperty, SweetBinding);
            RightBox.Items.Add(Sweet);
        }

        private void WaterControll()
        {
            LemonControll();
            IceControll();
        }

        private void CowboyCoffeeControll()
        {
            IceControll();

            CheckBox Decaf = new CheckBox();
            Decaf.Content = "Decaf";
            Decaf.HorizontalAlignment = HorizontalAlignment.Right;
            var DecafBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("Decaf"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };

            BindingOperations.SetBinding(Decaf, CheckBox.IsCheckedProperty, DecafBinding);

            CheckBox RoomForCream = new CheckBox();
            RoomForCream.Content = "RoomForCream";
            RoomForCream.HorizontalAlignment = HorizontalAlignment.Right;
            var RoomForCreamBinding = new Binding()
            {
                Source = DataContext,
                Path = new PropertyPath("RoomForCream"),
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.TwoWay
            };

            BindingOperations.SetBinding(RoomForCream, CheckBox.IsCheckedProperty, RoomForCreamBinding);
            RightBox.Items.Add(Decaf);
            RightBox.Items.Add(RoomForCream);
        }

        private void TexasTeaControll()
        {
            IceControll();
            LemonControll();
            SweetControll();

        }

        private void JerkedSodaControll()
        {
            IceControll();

        
        }






        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ((CheckBox)sender).GetBindingExpression(CheckBox.IsCheckedProperty).UpdateTarget();
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OrderControl orderControll = ((OrderControl)((Border)(this.Parent)).Parent);
            orderControll.SwapScreen();
           
        }
    }
}
