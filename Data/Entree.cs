/* Entree.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract Entree class
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Entree Price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Entree Calorie Count
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Entree special instructions
        /// </summary>
        /// <returns></returns>
        public abstract List<string> SpecialInstructions { get; }
    }
}
