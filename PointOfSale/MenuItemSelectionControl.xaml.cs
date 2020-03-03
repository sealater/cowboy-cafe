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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        // Event Handlers
        void OnAddAngryChickenButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new AngryChicken()); }
        }
        void OnAddCowpokeChiliButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new CowpokeChili()); } }
        void OnAddDakotaDoubleBurgerButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new DakotaDoubleBurger()); } }
        void OnAddPecosPulledPorkButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new PecosPulledPork()); } }
        void OnAddRustlersRibsButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new RustlersRibs()); } }
        void OnAddTexasTripleBurgerButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new TexasTripleBurger()); } }
        void OnAddTrailBurgerButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new TrailBurger()); } }

        void OnAddBakedBeansButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new BakedBeans()); } }
        void OnAddChiliCheeseFriesButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new ChiliCheeseFries()); } }
        void OnAddCornDodgersButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new CornDodgers()); } }
        void OnAddPanDeCampoButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new PanDeCampo()); } }

        void OnAddCowboyCoffeeButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new CowboyCoffee()); } }
        void OnAddJerkedSodaButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new JerkedSoda()); } }
        void OnAddTexasTeaButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new TexasTea()); } }
        void OnAddWaterButtonClick(object sender, RoutedEventArgs e) { if (DataContext is Order data) { data.AddItem(new Water()); } }
    }
}
