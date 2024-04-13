using pract5Tikolka.Models;
using pract5Tikolka.ViewModel.Cho_to_dlya_binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5Tikolka.ViewModel
{
    internal class KlikkerViewModel : BindingHelp
    {
        public BindingCliki ClickMoney { get; set; }

        private int _money;

        private string str_money;

        public string Money
        {
            get { return str_money; }
            set { str_money = value; OnPropertyChanged(); }
        }
        private Converter converter = new Converter();

        public KlikkerViewModel() 
        {
            ClickMoney = new BindingCliki(_ => MoneyClick());
        }

        public void MoneyClick()
        {
            _money += 100000;
            Money = $"Денег: {_money}";
            List<ReytingType> reytingTypes = converter.Jsonviser<List<ReytingType>>("Reyting.json") ?? new List<ReytingType>();
            reytingTypes.Last().Money = _money;
            converter.Jsonser(reytingTypes, "Reyting.json");
        }
    }
}
