/*
* Ian Slater
* Baked Beans : Side
* Data structure to resemble Baked Beans side
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class BakedBeans:Side
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
                    return 312;
                }
                else if (Size == Size.Medium)
                {
                    return 378;
                }
                else if (Size == Size.Large)
                {
                    return 410;
                }
                throw new NotImplementedException("unknown size");
            }
        }
        /// <summary>
        /// To string method tickets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            String title = $"{ Enum.GetName(typeof(Size), Size)}";
            title += " Baked Beans";
            return title;
        }
    }
}
