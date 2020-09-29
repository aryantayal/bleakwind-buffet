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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using PointOfSale.Drink;
using PointOfSale.Entree;
using PointOfSale.ExtensionMethod;
using PointOfSale.Sides;
using PointOfSale1;
using GardenOrcOmelette = PointOfSale.Entree.GardenOrcOmelette;
using SailorSoda = PointOfSale.Drink.SailorSoda;
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
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCandlehearth_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            MadOtar mo = new MadOtar();
            orderControl.swapScreen(mo);
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
        }

        private void bThugs_Click(object sender, RoutedEventArgs e)
        {
           
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
        }
    }
}
