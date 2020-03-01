/* Drink.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract Drink base class
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The drink's size (enum)
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The drink's price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The drink's calorie content
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Whether the drink will contain ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// A list of the drink's special instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
