/*
* Ian Slater
* Dakota Double Burger : Entree
* Data structure to resemble Dakota Double Burger entree 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger:Entree
    {
        /// <summary>
        /// event to trigger when special instructions are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        private bool bun = true;
        /// <summary>
        /// determines if there is a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Bun"));
                bun = value; }
        }

        private bool ketchup = true;
        /// <summary>
        /// determines if ketchup is added
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                ketchup = value; }
        }

        private bool mustard = true;
        /// <summary>
        /// determines if mustard is added
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                mustard = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// Determins if the burger has pickles.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                pickle = value; }
        }

        private bool cheese =true;
        /// <summary>
        /// Determins if the sandwich has pickles.
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                cheese = value; }
        }

        private bool tomato = true;
        /// <summary>
        /// determines if there is tomato added
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Bread"));
                tomato = value; }
        }


        private bool lettuce = true;
        /// <summary>
        /// determines if lettuce is added
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                lettuce = value; }
        }

        private bool mayo = true;
        /// <summary>
        /// determines if mayo is added
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                mayo = value; }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bun) instructions.Add("hold bun");
                if (!pickle) instructions.Add("hold pickle");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!cheese) instructions.Add("hold cheese");
                if (!tomato) instructions.Add("hold tomato");
                if (!mayo) instructions.Add("hold mayo");
                if (!lettuce) instructions.Add("hold lettuce");
                

                return instructions;
            }
        }

        /// <summary>
        /// To string method used for tickets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }

    }
}
