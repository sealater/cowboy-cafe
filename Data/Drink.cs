/* Drink.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract Drink base class
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Backing variable for Size
        /// </summary>
        private Size _size = Size.Small;
        /// <summary>
        /// The drink's size (enum)
        /// </summary>
        public Size Size { get => _size; set { _size = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size")); } }

        /// <summary>
        /// The drink's price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The drink's calorie content
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Backing variable for Ice
        /// </summary>
        private bool _ice = false;
        /// <summary>
        /// Whether the drink will contain ice
        /// </summary>
        public bool Ice { get => _ice; set { _ice = value; OnPropertyChanged(new PropertyChangedEventArgs("Ice")); } }

        /// <summary>
        /// A list of the drink's special instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Handler for use by sub-classes to override
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
