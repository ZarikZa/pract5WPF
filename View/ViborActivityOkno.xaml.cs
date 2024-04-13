using pract5Tikolka.Views;
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
    /// Логика взаимодействия для ViborActivityOkno.xaml
    /// </summary>
    public partial class ViborActivityOkno : Window
    {
        public ViborActivityOkno()
        {
            InitializeComponent();
        }
        private void PosmotretIstoriu_Button_Click(object sender, RoutedEventArgs e)
        {
            ReytingOkno reytingOkno = new ReytingOkno();
            reytingOkno.Show();
            Close();
        }

        private void ExitBtm_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void IgraBtm_Click(object sender, RoutedEventArgs e)
        {
            IgraOkno okno = new IgraOkno();
            okno.Show();
            Close();
        }

        private void KlikkerBtm_Click(object sender, RoutedEventArgs e)
        {
            KlikkerOkno klikkerOkno = new KlikkerOkno();
            klikkerOkno.Show();
            Close();
        }
    }
}
