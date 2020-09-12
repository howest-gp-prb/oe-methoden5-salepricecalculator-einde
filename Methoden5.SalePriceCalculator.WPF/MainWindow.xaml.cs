using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Methoden5.SalePriceCalculator.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rdbEndUser_Checked(object sender, RoutedEventArgs e)
        {
            double defaultPrice = double.Parse(txtDefaultSalePrice.Text);
            lblSalePrice.Content = CalculateSalePrice(defaultPrice).ToString("#,##0.00");
        }

        private void rdbShopOwner_Checked(object sender, RoutedEventArgs e)
        {
            double defaultPrice = double.Parse(txtDefaultSalePrice.Text);
            lblSalePrice.Content = CalculateSalePrice(defaultPrice, 25).ToString("#,##0.00");

        }

        private void rdbWholeSaler_Checked(object sender, RoutedEventArgs e)
        {
            double defaultPrice = double.Parse(txtDefaultSalePrice.Text);
            lblSalePrice.Content = CalculateSalePrice(defaultPrice, 35).ToString("#,##0.00");

        }
        private double CalculateSalePrice(double defaultPrice, double discountPerCent = 0)
        {
            double discount = defaultPrice * (discountPerCent/100);
            return defaultPrice - discount;
        }
    }
}
