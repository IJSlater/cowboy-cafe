/*
* Ian Slater
* Entree
*Parent class for Entres to inherit from 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree
    {
        

        /// <summary>
        /// skeleton parameter for price variable
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// skeleton parameter for the calories variable
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Skeleton parameter for the special instructions method
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        

    }
}
