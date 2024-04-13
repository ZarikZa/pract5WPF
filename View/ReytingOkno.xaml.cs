using pract5Tikolka.View;
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

namespace pract5Tikolka.Views
{
    /// <summary>
    /// Логика взаимодействия для ReytingOkno.xaml
    /// </summary>
    public partial class ReytingOkno : Window
    {
        public ReytingOkno()
        {
            InitializeComponent();
            DataContext = new ReytingViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViborActivityOkno viborActivityOkno = new ViborActivityOkno();
            viborActivityOkno.Show();
            Close();
        }
    }
}
