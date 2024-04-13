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
    /// Логика взаимодействия для IgraOkno.xaml
    /// </summary>
    public partial class IgraOkno : Window
    {
        public IgraOkno()
        {
            InitializeComponent();
            DataContext = new IgraViewModel();
            medel.Play();
        }

        private void ExitBtm_Click(object sender, RoutedEventArgs e)
        {
            ViborActivityOkno viborActivityOkno = new ViborActivityOkno();
            viborActivityOkno.Show();
            Close();
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Hidden;
        }
    }
}
