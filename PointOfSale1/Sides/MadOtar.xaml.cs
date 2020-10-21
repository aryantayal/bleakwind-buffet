using System.Windows;
using System.Windows.Controls;
using BleakwindBuffet.Data.Sides;
using PointOfSale.ExtensionMethod;
using PointOfSale1;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.Sides
{
    /// <summary>
    ///     Interaction logic for MadOtar.xaml
    /// </summary>
    public partial class MadOtar : UserControl
    {
        private readonly MadOtarGrits mo = new MadOtarGrits();

        public MadOtar()
        {
            InitializeComponent();
            DataContext = mo;
        }

        /// <summary>
        ///     After user selects the specification the done button it takes it back to the main menu selector
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var ms = new MenuSelector();
            orderControl.swapScreen(ms);
        }

        private void ComboBox1_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is MadOtarGrits)
                foreach (ComboBox s in e.AddedItems)
                {
                    if (s.Name == "Small") mo.Size = Size.Small;
                    if (s.Name == "Medium") mo.Size = Size.Medium;
                    if (s.Name == "Large") mo.Size = Size.Large;
                }
        }

        private void DoneComboButton_OnClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<MainWindow>();
            var cp = new ComboPage();
            orderControl.swapScreen(cp);
        }
    }
}