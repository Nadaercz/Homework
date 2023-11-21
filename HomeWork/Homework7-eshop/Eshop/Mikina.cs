using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    internal class Mikina : Odev
    {
        public Mikina(int cena, string velikost, bool jeKapuce) : base(cena, velikost, "zelena", "teplakovina")
        {
            MaKapuce = jeKapuce;
            StylKapes = "vsite";
        }

        public string StylKapes { get; set; }
        public bool MaKapuce { get; set; }
    }
}
