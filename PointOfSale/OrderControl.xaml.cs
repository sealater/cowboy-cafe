﻿/* OrderControl.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();

            DataContext = new Order();
        }

        /// <summary>
        /// Swap child element with given element
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        // Event Handlers
        void OnCompleteOrderButtonClick(object sender, RoutedEventArgs e) { this.DataContext = new Order(); }
        void OnCancelOrderButtonClick(object sender, RoutedEventArgs e) { this.DataContext = new Order(); }

        private void ItemSelectionButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}