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
using BleakwindBuffet.Data.Sides;
using PointOfSale.ExtensionMethod;
using PointOfSale.Sides;
using PointOfSale1;
using FriedMiraak = PointOfSale.Sides.FriedMiraak;
using VokunSalad = PointOfSale.Sides.VokunSalad;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SidePage.xaml
    /// </summary>
    public partial class SidePage : UserControl
    {
        public SidePage()
        {
            InitializeComponent();
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
    }
}
