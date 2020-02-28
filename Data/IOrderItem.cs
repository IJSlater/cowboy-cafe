/*
* Ian Slater
* IOrderItem
* Parent Class for all Items that will go on an item 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
         double Price { get; }
         uint Calories { get; }
         List<String> SpecialInstructions { get; }


    }
}
