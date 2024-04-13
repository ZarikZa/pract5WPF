using pract5Tikolka.ViewModel.Cho_to_dlya_binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pract5Tikolka.ViewModel
{
    internal class ShopViewModel
    {
        public BindingCliki ClickBuy { get; set; }

        public ShopViewModel() 
        {
            ClickBuy = new BindingCliki(_ => BuyClick());
        }
        
        public void BuyClick()
        {
            MessageBox.Show("Отрицательная цена, нельзя купить");
        }
    }
}
