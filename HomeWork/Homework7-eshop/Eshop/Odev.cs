using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    internal class Odev
    {
        public int Cena { get; set; }
        public string Velikost { get; set; }
        public string Barva { get; set;}
        public string Material { get; set;}
        public Odev(int cena, string velikost, string barva, string material) 
        {
            Cena = cena;
            Velikost = velikost;
            Barva = barva;
            Material = material;
        }

        public void Prodej(int pocetKusu)
        { }
        public void Naskladni(int pocetKusu)
        { }
    }
}
