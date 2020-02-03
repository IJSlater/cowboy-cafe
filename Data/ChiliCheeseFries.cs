using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side
    {

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

    }
}
