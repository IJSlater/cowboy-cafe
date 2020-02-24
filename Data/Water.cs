/*
* Ian Slater
* CowBoyCoffe : Drink
* Data structure to resemble Texas Tea drink. 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// Determines the size of the drink
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// Determines wether or not there is ice in the drink
        /// </summary>
        public override bool Ice { get; set; } = true;

        /// <summary>
        /// determins wether or not there is lemon in the drink
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Determins the price of the drink based on the size of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }
        /// <summary>
        /// determins the the number of calories in the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Determins the special intstructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice)
                {
                    instructions.Add("Hold Ice");
                }
                if (Lemon)
                {
                    instructions.Add("Lemon");
                }
                return instructions;

            }
        }

        /// <summary>
        /// To string method tickets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String title = "Water";
            title += $", { Enum.GetName(typeof(Size), Size)}";
            return title;
        }
    }
}
