/*
* Ian Slater
* Drink
*Parent class for dirnks to inherit from 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Drink : IOrderItem
    {

        /// <summary>
        /// Holds wehter or  not a drink has ice
        /// </summary>
        public abstract bool Ice { get; set; }

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets the price of the ddrink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Skeleton parameter for the special instructions method
        /// </summary>
        public virtual List<string> SpecialInstructions 
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)
                {
                    instructions.Add("Hold Ice");
                }
                return instructions;
            
            }
        }
    }
}
