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

namespace DuckShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Btn_autor(object sender, RoutedEventArgs e)
        {
            if (TBox_Login.Text == "KorolevMM")
            { 
                if (TBox_Password.Text == "Korolev")
                {
                    HelloWindow hw = new HelloWindow();
                    this.Hide();
                   
                    DateTime d = DateTime.Now.AddSeconds(3);

                    while (DateTime.Compare(DateTime.Now, d) <= 0)
                    { 
                       hw.ShowDialog();

                       if (DateTime.Compare(DateTime.Now, d) == 0)
                            hw.Hide(); 
                    }

                    
                    SalesMan smw = new SalesMan();
                    smw.ShowDialog();

                }
                else MessageBox.Show("Неверный пароль");
            }            
            else MessageBox.Show("Неерный логин");
        }
    }
}
