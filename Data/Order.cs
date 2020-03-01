/* Order.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        // Record of last Order number
        private static uint lastOrderNumber = 0;

        // Order's OrderNumber identifier
        public uint OrderNumber { get; }

        // Items contained within Order
        private List<IOrderItem> items = new List<IOrderItem>();

        // Public accessor for Order items
        public IEnumerable<IOrderItem> Items { get => items.ToArray(); }

        // Order subtotal
        public double Subtotal { 
            get
            {
                double subtotal = 0;

                foreach (IOrderItem item in items)
                {
                    subtotal += item.Price;
                }

                // if Subtotal != subtotal then call PropertyChanged?

                return subtotal;
            }
        }

        // Event handler for a property change on Order
        public event PropertyChangedEventHandler PropertyChanged;

        // Adds an item to Order
        public void AddItem(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        // Removes specified item from Order
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
