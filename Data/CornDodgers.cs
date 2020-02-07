/* CornDodgers.cs
 * Author: Ethan Davis */

using System;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Corn Dodgers side
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// The price of this side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calorie content of this side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}