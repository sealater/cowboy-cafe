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
        }

        void OnAddAngryChickenButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new AngryChicken()); }
        void OnAddCowpokeChiliButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new CowpokeChili()); }
        void OnAddDakotaDoubleBurgerButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new DakotaDoubleBurger()); }
        void OnAddPecosPulledPorkButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new PecosPulledPork()); }
        void OnAddRustlersRibsButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new RustlersRibs()); }
        void OnAddTexasTripleBurgerButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new TexasTripleBurger()); }
        void OnAddTrailBurgerButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new TrailBurger()); }

        void OnAddBakedBeansButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new BakedBeans()); }
        void OnAddChiliCheeseFriesButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new ChiliCheeseFries()); }
        void OnAddCornDodgersButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new CornDodgers()); }
        void OnAddPanDeCampoButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new PanDeCampo()); }

        void OnAddCowboyCoffeeButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new CowboyCoffee()); }
        void OnAddJerkedSodaButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new JerkedSoda()); }
        void OnAddTexasTeaButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new TexasTea()); }
        void OnAddWaterButtonClick(object sender, RoutedEventArgs e) { OrderListView.Items.Add(new Water()); }
    }
}
