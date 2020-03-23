﻿/* TexasTripleBurger.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger : Entree
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
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// Backing variable for Bun
        /// </summary>
        private bool _bun = true;

        /// <summary>
        // If the entree has a bun
        /// </summary>
        public bool Bun { get => _bun; set { _bun = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun")); } }

        /// <summary>
        /// Backing variable for Ketchup
        /// </summary>
        private bool _ketchup = true;

        /// <summary>
        // If the entree has ketchup
        /// </summary>
        public bool Ketchup { get => _ketchup; set { _ketchup = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup")); } }

        /// <summary>
        /// Backing variable for Mustard
        /// </summary>
        private bool _mustard = true;

        /// <summary>
        // If the entree has mustard
        /// </summary>
        public bool Mustard { get => _mustard; set { _mustard = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard")); } }

        /// <summary>
        /// Backing variable for Pickle
        /// </summary>
        private bool _pickle = true;

        /// <summary>
        // If the entree has pickle
        /// </summary>
        public bool Pickle { get => _pickle; set { _pickle = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle")); } }

        /// <summary>
        /// Backing variable for Cheese
        /// </summary>
        private bool _cheese = true;

        /// <summary>
        // If the entree has cheese
        /// </summary>
        public bool Cheese { get => _cheese; set { _cheese = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese")); } }

        /// <summary>
        /// Backing variable for Tomato
        /// </summary>
        private bool _tomato = true;

        // If the entree has tomato
        /// </summary>
        public bool Tomato { get => _tomato; set { _tomato = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato")); } }

        /// <summary>
        /// Backing variable for Lettuce
        /// </summary>
        private bool _lettuce = true;

        /// <summary>
        // If the entree has lettuce
        /// </summary>
        public bool Lettuce { get => _lettuce; set { _lettuce = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce")); } }

        /// <summary>
        /// Backing variable for Mayo
        /// </summary>
        private bool _mayo = true;

        /// <summary>
        // If the entree has mayo
        /// </summary>
        public bool Mayo { get => _mayo; set { _mayo = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo")); } }

        /// <summary>
        /// Backing variable for Bacon
        /// </summary>
        private bool _bacon = true;

        /// <summary>
        // If the entree has bacon
        /// </summary>
        public bool Bacon { get => _bacon; set { _bacon = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon")); } }

        /// <summary>
        /// Backing variable for Egg
        /// </summary>
        private bool _egg = true;

        /// <summary>
        // If the entree has egg
        /// </summary>
        public bool Egg { get => _egg; set { _egg = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg")); } }

        /// <summary>
        /// Special instructions for the preparation of the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");
                if (!Bacon) instructions.Add("hold bacon");
                if (!Egg) instructions.Add("hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}

