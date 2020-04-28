/*
* Ian Slater
* Texas Triple Burger : Entree
* Data structure to resemble Texas Triple Burger entree 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger:Entree
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
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
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

        private bool cheese = true;
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
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Tomato"));
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

        private bool bacon = true;
        /// <summary>
        /// Determins if the burger has bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                bacon = value; }
        }

        private bool egg = true;
        /// <summary>
        /// Determins if the burger has egg.
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Egg"));
                egg = value; }
        }
        /// <summary>
        /// 
        /// </summary>
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
                if (!egg) instructions.Add("hold egg");
                if (!bacon) instructions.Add("hold bacon");


                return instructions;
            }
        }

        /// <summary>
        /// To string method tickets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String title = "Texas Triple Burger";
            return title;
        }
    }
}
