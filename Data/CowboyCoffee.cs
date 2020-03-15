/*
* Ian Slater
* CowBoyCoffe : Drink
* Data structure to resemble Cowboy Coffe drink. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
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
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }

        /// <summary>
        /// Determines wether or not there is ice in the drink
        /// </summary>
        private bool ice = false;
        public override bool Ice
        {
            get { return ice; }
            set
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Ice"));
                ice = value;
            }
        }


        /// <summary>
        /// determins if the coffe will have cream or not
        /// </summary>
        private bool roomforcream=false;
        public bool RoomForCream
        {
            get { return roomforcream; }
            set
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                roomforcream = value;
            }
        }

        /// <summary>
        /// determins if the coffe is decaf or not
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                decaf = value;
            }
        }
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
            String title = $"{ Enum.GetName(typeof(Size), Size)} ";
            if (Decaf)
            {
                title += "Decaf ";
            }
            title += "Cowboy Coffee";

            return title;
        }

    }
}
