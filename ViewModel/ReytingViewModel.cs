using pract5Tikolka.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace pract5Tikolka.ViewModel
{
    internal class ReytingViewModel
    {
        private List<ReytingType> reytingTypes;

        public List<ReytingType> ReytingTypes
        {
            get { return reytingTypes; }
            set { reytingTypes = value; }
        }

        public ReytingViewModel()
        {
            Converter converter = new Converter();
            List<ReytingType>  reyting = converter.Jsonviser<List<ReytingType>>("Reyting.json") ?? new List<ReytingType>();
            for (int i = 0; i < reyting.Count; i++)
            {
                if (reyting[i].KolvoNajatiy == 0)
                {
                    if(reyting[i].Name !=  reyting.Last().Name)
                    {
                        reyting.Remove(reyting[i]);
                    }
                }
            }
            //Спросить как это сдлеать с ObserevableCollection
            reytingTypes = reyting.OrderBy(x => x.KolvoNajatiy).ToList();
            for (int i = 0;i < reytingTypes.Count;i++)
            {
                reytingTypes[i].Mesto = i+1;
            }
            converter.Jsonser(reytingTypes, "Reyting.json");
        }
    }
}
