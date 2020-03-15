/*
* Ian Slater
* Side
*Parent class for Sides to inherit from 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gives the values of sizes for databinding
        /// </summary>
        public virtual IEnumerable<Size> SizeValues => Enum.GetValues(typeof(Size)).Cast<Size>();

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        public virtual List<string> SpecialInstructions { get => new List<string>(); }
    }
}
