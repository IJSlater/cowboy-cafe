/*
* Ian Slater
* Order
* Class to handle what is showon the ticket
*/
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;


namespace CowboyCafe.Data
{
    public class Order :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Order()
        {
            OrderNumber += 1;
            //PropertyChanged.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));

        }



        private double subtotal = 0.0;
        public double Subtotal
        {
            get
            {
                subtotal = 0.0;
                foreach (IOrderItem i in items)
                {
                    subtotal += i.Price;
                }
                return subtotal;
            }
        }

        public static uint OrderNumber = 1;



        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items {get => items.ToArray();}

        public void Add(IOrderItem i)
        {
            i.PropertyChanged += OnInstructionAdded;
            items.Add(i);
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void OnInstructionAdded(object sender, PropertyChangedEventArgs e)
        {
            if (sender != null && this!=null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Items"));
            }
        }

        public void Remove(IOrderItem i)
        {
            items.Remove(i);
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Items"));
        }


    }
}
