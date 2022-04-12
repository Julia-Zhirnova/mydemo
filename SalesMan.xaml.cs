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
using System.Windows.Shapes;

namespace DuckShop
{
    /// <summary>
    /// Interaction logic for SalesMan.xaml
    /// </summary>
    public partial class SalesMan : Window
    {
        public SalesMan()
        {
            InitializeComponent();
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Btn_PAY(object sender, RoutedEventArgs e)
        {
            SaleWindow sw = new SaleWindow();
            this.Hide();
            sw.ShowDialog();
        }
    }
}
