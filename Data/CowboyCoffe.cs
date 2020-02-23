using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffe : Drink
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
        /// determins if the coffe will have cream or not
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// determins if the coffe is decaf or not
        /// </summary>
        public bool Decaf { get; set; } = false;

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
                        return 0.60;
                    case (Size.Medium):
                        return 1.10;
                    case (Size.Large):
                        return 1.60;
                }
                throw new InvalidOperationException("reached size that is not allowed");
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 3;
                    case (Size.Medium):
                        return 5;
                    case (Size.Large):
                        return 7;
                }
                throw new InvalidOperationException("reached size that is not allowed");
            }
        }
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)
                {
                    instructions.Add("Add Ice");
                }
                if (RoomForCream)
                {
                    instructions.Add("Room for Cream");
                }
                return instructions;

            }
        }

        /// <summary>
        /// To string method used for tickets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String title = "Cowboy Coffe";
            if (Decaf)
            {
                title += ", Decaf";
            }
            switch (Size)
            {
                case Size.Small:
                    title += ", small";
                    break;
                case Size.Medium:
                    title += ", medium";
                    break;
                case Size.Large:
                    title += ", large";
                    break;
                default:
                    throw new NotImplementedException("unknown size");

            }

            return title;
        }

    }
}
