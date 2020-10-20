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
    /// Interaction logic for MenuSelector.xaml
    /// </summary>
    public partial class MenuSelector : UserControl
    {
        /// <summary>
        /// Initalizes the Menu selector
        /// </summary>
        public MenuSelector()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBriarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>(); 
            BurgerBriar bb = new BurgerBriar();
            orderControl.swapScreen(bb);
            BleakwindBuffet.Data.Entree.BriarheartBurger item = new BriarheartBurger();
            Order o = (Order) orderControl.DataContext;
            bb.DataContext = item;
            o.Add(item);

            
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSalor_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            SailorSoda ss = new SailorSoda();
            orderControl.swapScreen(ss);
            BleakwindBuffet.Data.Drinks.SailorSoda item = new BleakwindBuffet.Data.Drinks.SailorSoda();
            Order o = (Order)orderControl.DataContext;
            ss.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bVokunSalad_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            VokunSalad vs = new VokunSalad();
            orderControl.swapScreen(vs);
            BleakwindBuffet.Data.Sides.VokunSalad item = new BleakwindBuffet.Data.Sides.VokunSalad();
            Order o = (Order)orderControl.DataContext;
            vs.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDoubleDragur_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            DoubleDragur dd = new DoubleDragur();
            orderControl.swapScreen(dd);
            BleakwindBuffet.Data.Entree.DoubleDraugr item =new DoubleDraugr();
            Order o = (Order)orderControl.DataContext;
            dd.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMakath_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            cMarkarthMilk mm = new cMarkarthMilk();
            orderControl.swapScreen(mm);
            BleakwindBuffet.Data.Drinks.MarkarthMilk item = new MarkarthMilk();
            Order o = (Order)orderControl.DataContext;
            mm.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bFriedM_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            FriedMiraak fm = new FriedMiraak();
            orderControl.swapScreen(fm);
            BleakwindBuffet.Data.Sides.FriedMiraak item = new BleakwindBuffet.Data.Sides.FriedMiraak();
            Order o = (Order)orderControl.DataContext;
            fm.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAretino_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            orderControl.swapScreen(aaj);
            BleakwindBuffet.Data.Drinks.AretinoAppleJuice item = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
            Order o = (Order)orderControl.DataContext;
            aaj.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bMadOtar_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            MadOtar mo = new MadOtar();
            orderControl.swapScreen(mo);
            BleakwindBuffet.Data.Sides.MadOtarGrits item = new MadOtarGrits();
            Order o = (Order)orderControl.DataContext;
            mo.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDragonW_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            orderControl.swapScreen(df); 
            BleakwindBuffet.Data.Sides.DragonbornWaffleFries item = new BleakwindBuffet.Data.Sides.DragonbornWaffleFries();
            Order o = (Order)orderControl.DataContext;
            df.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCandlehearth_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            CandleheartCoffee mo = new CandleheartCoffee();
            orderControl.swapScreen(mo);
            BleakwindBuffet.Data.Drinks.CandlehearthCoffee item = new BleakwindBuffet.Data.Drinks.CandlehearthCoffee();
            Order o = (Order)orderControl.DataContext;
            mo.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSmokehouse_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            orderControl.swapScreen(ss);
            BleakwindBuffet.Data.Entree.SmokehouseSkeleton item = new BleakwindBuffet.Data.Entree.SmokehouseSkeleton();
            Order o = (Order)orderControl.DataContext;
            ss.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bGarden_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            orderControl.swapScreen(goo);
            BleakwindBuffet.Data.Entree.GardenOrcOmelette item = new BleakwindBuffet.Data.Entree.GardenOrcOmelette();
            Order o = (Order)orderControl.DataContext;
            goo.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bWarriorW_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            WarriorWater ww = new WarriorWater();
            orderControl.swapScreen(ww);
            BleakwindBuffet.Data.Drinks.WarriorWater item = new BleakwindBuffet.Data.Drinks.WarriorWater();
            Order o = (Order)orderControl.DataContext;
            ww.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPhillyP_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            cPhilly pp = new cPhilly();
            orderControl.swapScreen(pp);
            BleakwindBuffet.Data.Entree.PhillyPoacher item = new PhillyPoacher();
            Order o = (Order)orderControl.DataContext;
            pp.DataContext = item;
            o.Add(item);
        }

        private void bThugs_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            cThugs t = new cThugs();
            orderControl.swapScreen(t);
            BleakwindBuffet.Data.Entree.ThugsTBone item = new ThugsTBone();
            Order o = (Order)orderControl.DataContext;
            t.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bTahlmorTriple_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            ThalmorTriple tt = new ThalmorTriple();
            orderControl.swapScreen(tt);
            BleakwindBuffet.Data.Entree.ThalmorTriple item = new BleakwindBuffet.Data.Entree.ThalmorTriple();
            Order o = (Order)orderControl.DataContext;
            tt.DataContext = item;
            o.Add(item);
        }

        private void bCombo_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            ComboPage cp = new ComboPage();
            orderControl.swapScreen(cp);
        }
    }
}
