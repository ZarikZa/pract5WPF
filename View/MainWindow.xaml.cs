using pract5Tikolka.Models;
using pract5Tikolka.View;
using pract5Tikolka.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pract5Tikolka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Converter Convert = new Converter();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Nacht_Button_Click(object sender, RoutedEventArgs e)
        {
           
            if (NameTbx.Text != "")
            {
                bool proverka  = true;
                var list = Convert.Jsonviser<List<ReytingType>>("Reyting.json");
                foreach (var item in list)
                {
                    if(item.Name == NameTbx.Text)
                    {
                        proverka = false;
                    }
                }
                if(proverka == true)
                {
                    ViborActivityOkno viborActivityOkno = new ViborActivityOkno();
                    viborActivityOkno.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Введите имя!!!!");
            }
        }
    }
}
