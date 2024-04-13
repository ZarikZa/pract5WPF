using pract5Tikolka.Models;
using pract5Tikolka.ViewModel.Cho_to_dlya_binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;

namespace pract5Tikolka.ViewModel
{
    internal class MainViewModel : BindingHelp
    {
        public BindingCliki AddIgrok {  get; set; }

        private ObservableCollection<ReytingType> reytingTypes;

        private string name;
        public string Name
        {
            get { return name; }
            set 
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private Converter converter = new Converter();
        public MainViewModel() 
        {
            reytingTypes = converter.Jsonviser<ObservableCollection<ReytingType>>("Reyting.json") ?? new ObservableCollection<ReytingType>();
            AddIgrok = new BindingCliki(_ => DobavIgrok());
        }
        
        public void DobavIgrok()
        {
            if(name != "")
            {
                bool proverka= true;
                List<ReytingType> pobediteli = converter.Jsonviser<List<ReytingType>>("Reyting.json") ?? new List<ReytingType>();
                foreach (var item in pobediteli)
                {
                    if(item.Name == name)
                    {
                        proverka = false;
                    }
                }
                if(proverka == true)
                {
                    reytingTypes.Add(new ReytingType(name, 0, 0, 0));
                    converter.Jsonser(reytingTypes, "Reyting.json");
                }
                else if(proverka == false)
                {
                    MessageBox.Show("Такой логин уже есть");
                }
            }
        }
    }
}
