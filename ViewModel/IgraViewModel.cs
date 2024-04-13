using pract5Tikolka.Models;
using pract5Tikolka.ViewModel.Cho_to_dlya_binding;
using pract5Tikolka.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace pract5Tikolka.ViewModel
{
    internal class IgraViewModel : BindingHelp
    {
        public BindingCliki ButtonClick { get; set; }
        public BindingCliki BeginClick { get; set; }

        public int chislo_hodov;

        private Converter converter = new Converter();

        private int x;

        public int X
        {
            get { return x; }
            set { x = value; OnPropertyChanged(); }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; OnPropertyChanged(); }
        }

        private Uri musika;

        public Uri Misika
        {
            get { return musika; }
            set { musika = value; OnPropertyChanged(); }
        }


        private bool enabled;

        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; OnPropertyChanged(); }
        }
         private bool enabledStart;

        public bool EnabledStart
        {
            get { return enabledStart; }
            set { enabledStart = value; OnPropertyChanged(); }
        }

        public IgraViewModel() 
        {
            ButtonClick = new BindingCliki(Click);
            BeginClick = new BindingCliki (_ => biginClick());
            List<string> musik = new List<string>() { "C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\Новая папка\\Karnaval_-_Psikhushka_70027932.mp3", "C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\Новая папка\\daryana_daybe_-_Zastavlyal_75753914.mp3", "C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\Новая папка\\LOVV66_-_Trap_Trap_72983534.mp3", "C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\Новая папка\\TATISIZE_PASHASNICKERS_-_TATI_74781372.mp3", "C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\Новая папка\\shadowraze_-_astral_step_73829396.mp3", "C:\\Users\\MSI-MODERN-14\\OneDrive\\Desktop\\Новая папка\\Валя_Карнавал_Частушка_Hardstyle_Remix.mp3" };
            Random random = new Random();
            Misika = new Uri(musik[random.Next(1,6)]);
            Enabled = false;
            EnabledStart = true;  
        }

        public void Click(object parametr)
        {
            chislo_hodov++;
            List<ReytingType> reytingTypes = converter.Jsonviser<List<ReytingType>>("Reyting.json") ?? new List<ReytingType>();
            reytingTypes.Last().KolvoNajatiy = chislo_hodov;
            converter.Jsonser(reytingTypes, "Reyting.json");
            string provilno = $"{y},{x}";
            if(provilno == parametr.ToString())
            {
                MessageBox.Show($"Вы нашли Софию Алексеевну за {chislo_hodov} ходов");
                Enabled = false;
            }
            else if (chislo_hodov == 10)
            {
                MessageBox.Show("Вы не нашли Софию Алексеевну!!");
                Enabled = false;
            }
        }

        public void biginClick()
        {
            Random random = new Random();
            X = random.Next(1, 5);
            Y = random.Next(1, 5);
            Enabled = true;
            EnabledStart = false;
        }
    }
}
