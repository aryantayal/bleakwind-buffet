using System.Windows;
using System.Windows.Controls;
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
    ///     Interaction logic for SidePage.xaml
    /// </summary>
    public partial class SidePage : UserControl
    {
        private readonly Combo combo;

        public SidePage(Combo c)
        {
            InitializeComponent();
            combo = c;
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
            combo.Side = item;
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
            combo.Side = item;
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
            combo.Side = item;
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
            combo.Side = item;
        }
    }
}