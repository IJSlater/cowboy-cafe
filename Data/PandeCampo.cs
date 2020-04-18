/*
* Ian Slater
* Pan De Campo : Side
* Data structure to resemble Pan De campo side
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    public class PanDeCampo : Side
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
                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Size"));
                size = value;
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
                    return 227;
                }
                else if (Size == Size.Medium)
                {
                    return 269;
                }
                else if (Size == Size.Large)
                {
                    return 367;
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
            title += " Pan de Campo";
            return title;
        }

    }
}
