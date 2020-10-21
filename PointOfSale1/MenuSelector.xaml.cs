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
using FriedMiraak = PointOfSale.Sides.FriedMiraak;
using GardenOrcOmelette = PointOfSale.Entree.GardenOrcOmelette;
using SailorSoda = PointOfSale.Drink.SailorSoda;
using VokunSalad = PointOfSale.Sides.VokunSalad;
using WarriorWater = PointOfSale.Drink.WarriorWater;

namespace PointOfSale
{
    /// <summary>
    ///     Interaction logic for MenuSelector.xaml
    /// </summary>
    public partial class MenuSelector : UserControl
    {
        /// <summary>
        ///     Initalizes the Menu selector
        /// </summary>
        public MenuSelector()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBriarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var bb = new BurgerBriar();
            orderControl.swapScreen(bb);
            var item = new BriarheartBurger();
            var o = (Order) orderControl.DataContext;
            bb.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSalor_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var ss = new SailorSoda();
            orderControl.swapScreen(ss);
            var item = new BleakwindBuffet.Data.Drinks.SailorSoda();
            var o = (Order) orderControl.DataContext;
            ss.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bVokunSalad_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var vs = new VokunSalad();
            orderControl.swapScreen(vs);
            var item = new BleakwindBuffet.Data.Sides.VokunSalad();
            var o = (Order) orderControl.DataContext;
            vs.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDoubleDragur_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var dd = new DoubleDragur();
            orderControl.swapScreen(dd);
            var item = new DoubleDraugr();
            var o = (Order) orderControl.DataContext;
            dd.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMakath_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var mm = new cMarkarthMilk();
            orderControl.swapScreen(mm);
            var item = new MarkarthMilk();
            var o = (Order) orderControl.DataContext;
            mm.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bFriedM_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var fm = new FriedMiraak();
            orderControl.swapScreen(fm);
            var item = new BleakwindBuffet.Data.Sides.FriedMiraak();
            var o = (Order) orderControl.DataContext;
            fm.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAretino_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var aaj = new AretinoAppleJuice();
            orderControl.swapScreen(aaj);
            var item = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
            var o = (Order) orderControl.DataContext;
            aaj.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMadOtar_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var mo = new MadOtar();
            orderControl.swapScreen(mo);
            var item = new MadOtarGrits();
            var o = (Order) orderControl.DataContext;
            mo.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDragonW_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var df = new DragonbornWaffleFries();
            orderControl.swapScreen(df);
            var item = new BleakwindBuffet.Data.Sides.DragonbornWaffleFries();
            var o = (Order) orderControl.DataContext;
            df.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCandlehearth_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var mo = new CandleheartCoffee();
            orderControl.swapScreen(mo);
            var item = new CandlehearthCoffee();
            var o = (Order) orderControl.DataContext;
            mo.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSmokehouse_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var ss = new SmokehouseSkeleton();
            orderControl.swapScreen(ss);
            var item = new BleakwindBuffet.Data.Entree.SmokehouseSkeleton();
            var o = (Order) orderControl.DataContext;
            ss.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bGarden_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var goo = new GardenOrcOmelette();
            orderControl.swapScreen(goo);
            var item = new BleakwindBuffet.Data.Entree.GardenOrcOmelette();
            var o = (Order) orderControl.DataContext;
            goo.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bWarriorW_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var ww = new WarriorWater();
            orderControl.swapScreen(ww);
            var item = new BleakwindBuffet.Data.Drinks.WarriorWater();
            var o = (Order) orderControl.DataContext;
            ww.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPhillyP_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var pp = new cPhilly();
            orderControl.swapScreen(pp);
            var item = new PhillyPoacher();
            var o = (Order) orderControl.DataContext;
            pp.DataContext = item;
            o.Add(item);
        }

        private void bThugs_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var t = new cThugs();
            orderControl.swapScreen(t);
            var item = new ThugsTBone();
            var o = (Order) orderControl.DataContext;
            t.DataContext = item;
            o.Add(item);
        }

        /// <summary>
        ///     Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bTahlmorTriple_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var tt = new ThalmorTriple();
            orderControl.swapScreen(tt);
            var item = new BleakwindBuffet.Data.Entree.ThalmorTriple();
            var o = (Order) orderControl.DataContext;
            tt.DataContext = item;
            o.Add(item);
        }

        private void bCombo_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var cp = new ComboPage();
            orderControl.swapScreen(cp);
        }
    }
}