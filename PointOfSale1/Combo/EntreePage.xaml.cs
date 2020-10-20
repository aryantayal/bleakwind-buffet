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
        public EntreePage()
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
            var orderControl = this.FindAncestor<PointOfSale1.MainWindow>();
            BurgerBriar bb = new BurgerBriar();
            orderControl.swapScreen(bb);
            BleakwindBuffet.Data.Entree.BriarheartBurger item = new BriarheartBurger();
            Order o = (Order)orderControl.DataContext;
            bb.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDoubleDragur_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<PointOfSale1.MainWindow>();
            DoubleDragur dd = new DoubleDragur();
            orderControl.swapScreen(dd);
            BleakwindBuffet.Data.Entree.DoubleDraugr item = new DoubleDraugr();
            Order o = (Order)orderControl.DataContext;
            dd.DataContext = item;
            o.Add(item);
        }
        /// <summary>
        /// Opens the customization page upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSmokehouse_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<PointOfSale1.MainWindow>();
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
            var orderControl = this.FindAncestor<PointOfSale1.MainWindow>();
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
        private void bPhillyP_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<PointOfSale1.MainWindow>();
            Entree.cPhilly pp = new Entree.cPhilly();
            orderControl.swapScreen(pp);
            BleakwindBuffet.Data.Entree.PhillyPoacher item = new PhillyPoacher();
            Order o = (Order)orderControl.DataContext;
            pp.DataContext = item;
            o.Add(item);
        }
        private void bThugs_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<PointOfSale1.MainWindow>();
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
    }
}
