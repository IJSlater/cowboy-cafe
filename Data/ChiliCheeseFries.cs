/*
* Ian Slater
* Chillie Cheese Fries : Side
* Data structure to resemble ChillieCheese Fries side
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// event to trigger when special instructions are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Property to manage the sides size
        /// </summary>
        private Size size = Size.Small;

        public override Size Size
        {
            get { return size; }
            set
            {
                
                size = value;
                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }
        /// <summary>
        /// Returns the items price
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.99;
                }
                else if (Size == Size.Medium)
                {
                    return 2.99;
                }
                else if (Size == Size.Large)
                {
                    return 3.99;
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
                    return 433;
                }
                else if (Size == Size.Medium)
                {
                    return 524;
                }
                else if (Size == Size.Large)
                {
                    return 610;
                }
                throw new NotImplementedException("unknown size"); ;
            }
        }

        /// <summary>
        /// To string method tickets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String title = $"{ Enum.GetName(typeof(Size), Size)}";
            title += " Chili Cheese Fries";
            return title;

        }
    }
}
