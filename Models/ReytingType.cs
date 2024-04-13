using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5Tikolka.Models
{
    internal class ReytingType
    {
        public string Name { get; set; }
        public int Mesto { get; set; }
        public int KolvoNajatiy { get; set; }
        public int Money { get; set; }


        public ReytingType(string name, int kolvoNajatiy, int mesto, int money)
        {
            Name=name;
            KolvoNajatiy=kolvoNajatiy;
            Mesto=mesto;
            Money=money;
        }
    }
}
