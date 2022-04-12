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
    /// Interaction logic for Sale.xaml
    /// </summary>
    public partial class SaleWindow : Window
    {
        public SaleWindow()
        {
            InitializeComponent();
        }

        private void ComboCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_PAY(object sender, RoutedEventArgs e)
        {
            Manager mw = new Manager();
            this.Hide();
            mw.ShowDialog();
        }
    }
}
