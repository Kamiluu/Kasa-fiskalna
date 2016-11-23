using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Produkt
    {
        private string nazwa;
        private double cenaJednostkowa;
        private int ilosc;


        public Produkt(string nazwa, double cenaJednostkowa, int ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;

        }
        public double dajCeneJednostkowa()
        {
            return cenaJednostkowa;
        }
        public int dajIlosc()
        {
            return ilosc;
        }
        public string dajInfo()
        {
            string info = nazwa.ToUpper() +" // Ilosc:  "+ ilosc + " // Cena jednostkowa: " +cenaJednostkowa + " // Lacznie: " +ilosc*cenaJednostkowa;

            return info;
        }
        

       
    }
}
