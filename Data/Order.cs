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



        public double Subtotal { get; set; } = 10.0;

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items {get => items;}

        public void Add(IOrderItem i)
        {
            items.Add(i);
            this.Subtotal += i.Price;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            

        
        }
        public void Remove(IOrderItem i)
        {

        }


    }
}
