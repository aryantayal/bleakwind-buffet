using System.Windows;
using System.Windows.Controls;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Drink;
using PointOfSale.Entree;
using PointOfSale.ExtensionMethod;
using PointOfSale.Sides;
using PointOfSale1;
using FriedMiraak = BleakwindBuffet.Data.Sides.FriedMiraak;
using GardenOrcOmelette = BleakwindBuffet.Data.Entree.GardenOrcOmelette;
using SailorSoda = BleakwindBuffet.Data.Drinks.SailorSoda;
using VokunSalad = BleakwindBuffet.Data.Sides.VokunSalad;
using WarriorWater = BleakwindBuffet.Data.Drinks.WarriorWater;

namespace PointOfSale
{
    /// <summary>
    ///     Interaction logic for OrderCompnent.xaml
    /// </summary>
    public partial class OrderCompnent : UserControl
    {
        public OrderCompnent()
        {
            InitializeComponent();
        }

        private void RemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order && sender is Button button && button.DataContext is IOrderItem item)
                order.Remove(item);
        }

        private void OrderItems_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FrameworkElement screen = null;
            var orderComp = this.FindAncestor<MainWindow>();
            if (DataContext is Order order)
                if (sender is ListBox lb)
                    if (lb.SelectedItem is IOrderItem item)
                    {
                        if (item is BriarheartBurger)
                        {
                            screen = new BurgerBriar();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is DoubleDraugr)
                        {
                            screen = new DoubleDragur();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is GardenOrcOmelette)
                        {
                            screen = new Entree.GardenOrcOmelette();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is PhillyPoacher)
                        {
                            screen = new cPhilly();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is BleakwindBuffet.Data.Entree.SmokehouseSkeleton)
                        {
                            screen = new SmokehouseSkeleton();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is BleakwindBuffet.Data.Entree.ThalmorTriple)
                        {
                            screen = new ThalmorTriple();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is ThugsTBone)
                        {
                            screen = new cThugs();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is DragonbornWaffleFries)
                        {
                            screen = new DragonbornWaffleFries();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is FriedMiraak)
                        {
                            screen = new Sides.FriedMiraak();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is MadOtarGrits)
                        {
                            screen = new MadOtar();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is VokunSalad)
                        {
                            screen = new Sides.VokunSalad();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is BleakwindBuffet.Data.Drinks.AretinoAppleJuice)
                        {
                            screen = new AretinoAppleJuice();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is CandlehearthCoffee)
                        {
                            screen = new CandleheartCoffee();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is MarkarthMilk)
                        {
                            screen = new cMarkarthMilk();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is WarriorWater)
                        {
                            screen = new Drink.WarriorWater();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                        else if (item is SailorSoda)
                        {
                            screen = new Drink.SailorSoda();
                            screen.DataContext = item;
                            orderComp?.swapScreen(screen);
                        }
                    }
        }

        private void CancelButton_OnClick(object includeSender, RoutedEventArgs includeE)
        {
            if (DataContext is Order o)
            {
                o = new Order();
                var i = this.FindAncestor<MainWindow>();
                i.DataContext = o;
            }
        }

        private void PayButton_OnClick(object includeSender, RoutedEventArgs includeE)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var ps = new PaymentScreen();
            orderControl.swapScreen(ps);
        }
    }
}