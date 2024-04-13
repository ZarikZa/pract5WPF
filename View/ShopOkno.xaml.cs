using pract5Tikolka.ViewModel;
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

namespace pract5Tikolka.View
{
    /// <summary>
    /// Логика взаимодействия для ShopOkno.xaml
    /// </summary>
    public partial class ShopOkno : Window
    {
        public ShopOkno()
        {
            InitializeComponent();
            DataContext = new ShopViewModel();
        }

        private void ExitBtm_Click(object sender, RoutedEventArgs e)
        {
            KlikkerOkno klikkerOkno = new KlikkerOkno();
            klikkerOkno.Show();
            Close();
        }
    }
}
