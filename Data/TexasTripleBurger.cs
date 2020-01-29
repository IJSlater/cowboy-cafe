using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger
    {

        /// <summary>
        /// The price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
            }
        }
        private bool bacon = true;
        /// <summary>
        /// Determins if the burger has bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        private bool egg;
        /// <summary>
        /// Determins if the burger has egg.
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

    }
}
