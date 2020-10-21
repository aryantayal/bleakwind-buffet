using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entree;
using PointOfSale.Entree;
using PointOfSale.ExtensionMethod;
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
using PointOfSale1;
using GardenOrcOmelette = PointOfSale.Entree.GardenOrcOmelette;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreePage.xaml
    /// </summary>
    public partial class EntreePage : UserControl
    {
        public EntreePage(Combo c)
        {
            InitializeComponent();
            combo = c;
        }

        private Combo combo = new Combo();

        /// <summary>
        /// Opens the customization page upon click
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
            combo.Entree = item;
        }

        /// <summary>
        /// Opens the customization page upon click
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
            combo.Entree = item;
        }

        /// <summary>
        /// Opens the customization page upon click
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
            combo.Entree = item;
        }

        /// <summary>
        /// Opens the customization page upon click
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
            combo.Entree = item;
        }

        /// <summary>
        /// Opens the customization page upon click
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
            combo.Entree = item;
        }

        private void bThugs_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var t = new cThugs();
            orderControl.swapScreen(t);
            var item = new ThugsTBone();
            var o = (Order) orderControl.DataContext;
            t.DataContext = item;
            combo.Entree = item;
        }

        /// <summary>
        /// Opens the customization page upon click
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
            combo.Entree = item;
        }
    }
}