/*
* Ian Slater
* CowBoyCoffe : Drink
* Data structure to resemble Texas Tea drink. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {

        /// <summary>
        /// event to trigger when special instructions are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Determines the size of the drink
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
        /// Determines wether or not there is ice in the drink
        /// </summary>
        private bool ice = true;
        public override bool Ice 
        {
                get { return ice; }
                set {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Ice"));
                    ice = value;
                }
        }

        /// <summary>
        /// determins wether or not there is lemon in the drink
        /// </summary>
        private bool lemon = false;
        public bool Lemon {
                get { return lemon; }
                set {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                    lemon = value;
                }
            }
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
            title += " Water";
            return title;
        }
    }
}
