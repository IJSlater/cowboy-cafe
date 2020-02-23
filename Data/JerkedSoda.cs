using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda: Drink
    {
        /// <summary>
        /// Determines the size of the drink
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// Determines wether or not there is ice in the drink
        /// </summary>
        public override bool Ice { get; set; } = true;

        public SodaFlavor Flavor { get; set; }

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
                        return 2.10;
                    case (Size.Medium):
                        return 2.10;
                    case (Size.Large):
                        return 2.59;
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
                        return 110;
                    case (Size.Medium):
                        return 146;
                    case (Size.Large):
                        return 198;
                }
                throw new InvalidOperationException("reached size that is not allowed");
            }
        }



    }
}
