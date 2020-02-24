/*
* Ian Slater
* Corn Dodger : Side
* Data structure to resemble Corn dodgers side
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CornDodgers : Side
    {

        /// <summary>
        /// Returns the items price
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.59;
                }
                else if (Size == Size.Medium)
                {
                    return 1.79;
                }
                else if (Size == Size.Large)
                {
                    return 1.99;
                }
                throw new NotImplementedException("unknown size");
            }
        }

        /// <summary>
        /// Returns the Calories in the item
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 512;
                }
                else if (Size == Size.Medium)
                {
                    return 685;
                }
                else if (Size == Size.Large)
                {
                    return 717;
                }
                throw new NotImplementedException("unknown size");
            }
        }

        /// <summary>
        /// To string method used for tickets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String title = "Corn Dodger";
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
