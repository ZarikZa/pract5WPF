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
    /// Логика взаимодействия для KlikkerOkno.xaml
    /// </summary>
    public partial class KlikkerOkno : Window
    {
        public KlikkerOkno()
        {
            InitializeComponent();
            DataContext = new KlikkerViewModel();
        }

        private void ExitBtm_Click(object sender, RoutedEventArgs e)
        {
            ViborActivityOkno vibor = new ViborActivityOkno();
            vibor.Show();
            Close();
        }

        private void ShopBtm_Click(object sender, RoutedEventArgs e)
        {
            ShopOkno shopOkno = new ShopOkno();
            shopOkno.Show();
            Close();
        }
    }
}
