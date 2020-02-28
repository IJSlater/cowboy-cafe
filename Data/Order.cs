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



        public double Subtotal { get; set; } = 0.00;

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items {get => items.ToArray();}

        public void Add(IOrderItem i)
        {
            items.Add(i);
            this.Subtotal += i.Price;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
        public void Remove(IOrderItem i)
        {

        }


    }
}
