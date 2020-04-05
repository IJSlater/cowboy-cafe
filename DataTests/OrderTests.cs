using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        public class MockOrderItem : IOrderItem, INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            double IOrderItem.Price { get; }
            uint IOrderItem.Calories { get; }
            List<String> IOrderItem.SpecialInstructions { get; }


        }

        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);



        }

        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);


        }



        [Fact]
        public void AngryChickenImplementsINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }

        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var chicken = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void ChiliCheeseFriesImplementsINotifyPropertyChanged()
        {
            var chicken = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void CornDodgersImplementsINotifyPropertyChanged()
        {
            var chicken = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void CowboyCoffeImplementsINotifyPropertyChanged()
        {
            var chicken = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void CowpokeChiliImplementsINotifyPropertyChanged()
        {
            var chicken = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void DakotaDoubleBurgerImplementsINotifyPropertyChanged()
        {
            var chicken = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void JerkedSodaImplementsINotifyPropertyChanged()
        {
            var chicken = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void PandeCampoImplementsINotifyPropertyChanged()
        {
            var chicken = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void PecosPulledPorkImplementsINotifyPropertyChanged()
        {
            var chicken = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void RustlersRibsImplementsINotifyPropertyChanged()
        {
            var chicken = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void TexasTeaImplementsINotifyPropertyChanged()
        {
            var chicken = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void TexasTripleBurgerImplementsINotifyPropertyChanged()
        {
            var chicken = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        [Fact]
        public void WaterImplementsINotifyPropertyChanged()
        {
            var chicken = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }


        [Fact]
        public void ShouldBeAbleToGetEnumerationOfItems()
        {
            var order = new Order();
            var itemA = new MockOrderItem();
            var itemB = new MockOrderItem();
            var itemC = new MockOrderItem();
            order.Add(itemA);
            order.Add(itemB);
            order.Add(itemC);

            Assert.Collection(order.Items,
                item => Assert.Equal(itemA, item),
                item => Assert.Equal(itemB, item),
                item => Assert.Equal(itemC, item)
                );

        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 0, 0, 0, })]
        [InlineData(new double[] { 1.99, 4.99, 6.99 })]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -10 })]
        [InlineData(new double[] { .78098954 })]
        [InlineData(new double[] { double.NaN, 'A' })]

        public void ShouldBeTheSumOfTheItemPrices(double[] prices)
        {
            var order = new Order();
            var total = 0.0;

            foreach (var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem()
                {
                    //Price = price
                }
                );

            }
            Assert.Equal(total, order.Subtotal);


        }

        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]
        public void AddingAnItemShouldTriggerPropertyChanged(string Propertyname)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, Propertyname, () =>
            {
                order.Add(item);

            }
            );

        }


        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string Propertyname)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, Propertyname, () =>
            {
                order.Remove(item);

            }
            );

        }







    }
}
