using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        public CurrencyControl()
        {
            InitializeComponent();
        }

        public static DependencyProperty dp = DependencyProperty.Register("Value", typeof(int),
            typeof(CurrencyControl),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public static DependencyProperty ChangeDependencyProperty = DependencyProperty.Register("Change", typeof(int),
            typeof(CurrencyControl),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public int Value
        {
            get => (int) GetValue(dp);
            set => SetValue(dp, value);
        }

        public int Change
        {
            get => (int) GetValue(ChangeDependencyProperty);
            set => SetValue(ChangeDependencyProperty, value);
        }

        private void Plus_OnClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Value++;
        }

        private void Minus_OnClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            if (Value != 0) Value--;
        }
    }
}