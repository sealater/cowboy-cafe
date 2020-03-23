/* AngryChicken.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree, INotifyPropertyChanged
    {
        // Property changed event to be bubbled up
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Backing variable for Bread
        /// </summary>
        private bool _bread = true;

        /// <summary>
        /// If the entree has bread
        /// </summary>
        public bool Bread { get => _bread; set { _bread = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread")); } }

        /// <summary>
        /// Backing variable for Pickle
        /// </summary>
        private bool _pickle = true;

        /// <summary>
        /// If the entree has pickles
        /// </summary>
        public bool Pickle { get => _pickle; set { _pickle = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle")); } }

        /// <summary>
        /// Special instructions for the preparation of the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}

