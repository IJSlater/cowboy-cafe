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

        public double Subtotal { get; set; }

        public IEnumerable<IOrderItem> Items {get;set;}

        public void Add(IOrderItem i)
        { 
        
        }
        public void Remove(IOrderItem i)
        {

        }


    }
}
