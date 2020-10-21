using System.Windows;
using BleakwindBuffet.Data;

namespace PointOfSale1
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Order();
        }

        /// <summary>
        ///     Sends the page to swap the pages
        /// </summary>
        /// <param name="u"></param>
        public void swapScreen(UIElement u)
        {
            ButtonBorder.Child = u;
        }
    }
}