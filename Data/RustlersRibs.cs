/*
* Ian Slater
* Rustlers Ribs: Entree
* Data structure to resemble Rustlers Ribs entree 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs:Entree
    {

        /// <summary>
        /// The price of the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }
        /// <summary>
        /// To string method tickets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String title = "Rustler's Ribs";
            return title;
        }
    }
}
