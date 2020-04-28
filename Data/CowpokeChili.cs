/*
* Ian Slater
* CowPoke Chillie : Entree
* Data structure to resemble CowPoke Chillie entree 
*/
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili : Entree
    {
        /// <summary>
        /// event to trigger when special instructions are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private bool cheese = true;
        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                cheese = value; }
        }

        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream
        {
            get { return sourCream; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("SourCream"));
                sourCream = value; }
        }

        private bool greenOnions = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions
        {
            get { return greenOnions; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("GreenOnions"));
                greenOnions = value; }
        }

        private bool tortillaStrips = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips
        {
            get { return tortillaStrips; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("TortillaStrips"));
                tortillaStrips = value; }
        }

        /// <summary>
        /// The price of the chili
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!sourCream) instructions.Add("hold sour cream");
                if (!greenOnions) instructions.Add("hold green onions");
                if (!tortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        /// <summary>
        /// To string method used for tickets
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Cowpoke Chili";
        }

    }
}

