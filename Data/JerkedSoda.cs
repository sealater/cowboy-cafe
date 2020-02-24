/* JerkedSoda.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class describing the JerkedSoda Drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// The price of this Drink
        /// </summary>
        public override double Price {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calorie content of this Drink
        /// </summary>
        public override uint Calories { 
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The SodaFlavor (enum) of this Drink
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Special instructions for the preparation of this Drink
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return $"Small {Flavor} Jerked Soda";
                case Size.Medium:
                    return $"Medium {Flavor} Jerked Soda";
                case Size.Large:
                    return $"Large {Flavor} Jerked Soda";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
