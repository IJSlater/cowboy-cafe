/*
* Ian Slater
* Angry chicken : Entree
* Data structure to resemble Angry chicken entree 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken : Entree// INotifyPropertyChanged

    {

        public event PropertyChangedEventHandler PropertyChanged;
        


        /// <summary>
        /// The price of the Sandwich
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the sandwich
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        private bool bread = true;
        /// <summary>
        /// Determins if the sandwich has bread.
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Bread"));
                    bread = value; 
                }
        }

        private bool pickle =true;

        

        /// <summary>
        /// Determins if the sandwich has pickles.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                    pickle = value; 
                }
        }
        
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");
                return instructions;
            }
        }



        /// <summary>
        /// Changs to string to be the 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
