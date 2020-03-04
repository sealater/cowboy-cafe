/* MenuItemSelectionControl.cs
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
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        private OrderControl orderControl;

        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        // Generic handler for ItemAddButton clicked event
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch(button.Tag)
                    {
                        case "Angry Chicken":
                            order.AddItem(new AngryChicken());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Cowpoke Chili":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Dakota Double Burger":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Pecos Pulled Pork":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Rustlers Ribs":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Texas Triple Burger":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Trail Burger":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Baked Beans":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Chili Cheese Fries":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Corn Dodgers":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Pan de Campo":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Cowboy Coffee":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Jerked Soda":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Texas Tea":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Water":
                            order.AddItem(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                    }
                }
            }
        }
    }
}
