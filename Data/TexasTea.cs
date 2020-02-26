/*
* Ian Slater
*  Texas Tea : Drink
* Data structure to resemble Texas Tea drink. 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
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
        /// dtermins if the Tea is seet or not
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// determins if the tea has lemon in it
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Determins the price of the drink based on the size of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.00;
                    case (Size.Medium):
                        return 1.50;
                    case (Size.Large):
                        return 2.00;
                }
                throw new InvalidOperationException("reached size that is not allowed");
            }
        }
        /// <summary>
        /// determins the calories in the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case (Size.Small):
                            return 10;
                        case (Size.Medium):
                            return 22;
                        case (Size.Large):
                            return 36;
                    }
                    throw new InvalidOperationException("reached size that is not allowed");
                }
                else
                {
                    switch (Size)
                    {
                        case (Size.Small):
                            return 5;
                        case (Size.Medium):
                            return 11;
                        case (Size.Large):
                            return 18;
                    }
                    throw new InvalidOperationException("reached size that is not allowed");

                }
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)
                {
                    instructions.Add("Hold Ice");
                }
                if (Lemon)
                {
                    instructions.Add("Add Lemon");
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
            String title = $"{ Enum.GetName(typeof(Size), Size)}";
            title += " Tea";
            return title;
        }
    }
}
