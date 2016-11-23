using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Koszyk
    {
        private List<Produkt> listaProduktow = new List<Produkt>();
        public List<Produkt> dodajProdukt(Produkt produkt)
        {
            
            listaProduktow.Add(produkt);

            return listaProduktow;
        }
        public List<Produkt> dajListe()
         {
             return listaProduktow;
         }
        public double wielkoscKoszyka()
        {
            return listaProduktow.Count();
        }
        public void wyswietlKoszyk()
        {
            int count = 0;
            foreach (Produkt produkt in listaProduktow)
            {
                count += 1;
                Console.WriteLine(+count + ") " + produkt.dajInfo());
            }
        }
        public void wyswietlKoszykParagon()
        {
            int count = 0;
            foreach (Produkt produkt in listaProduktow)
            {
                count += 1;
                Console.WriteLine(produkt.dajInfo()+"    " + produkt.dajIlosc()*produkt.dajCeneJednostkowa());
            }
        }

        public double kosztKoszyka()
        {
            double koszt = 0;
            foreach (Produkt produkt in listaProduktow)
            {
                koszt+=(produkt.dajIlosc()*produkt.dajCeneJednostkowa());
            }
            return koszt;
        }

        public void drukujParagon(double kasa)
        {
            Console.Clear();

            Console.WriteLine("                SKLEP   ");
            Console.WriteLine("********************************************");
            Console.WriteLine("          PARAGON FISKALNY   ");
            wyswietlKoszyk();
            Console.WriteLine("********************************************");
            Console.WriteLine("SUMA: " + kosztKoszyka());
            Console.WriteLine("Gotowka: "+ kasa);
            Console.WriteLine("Reszta: "+ Convert.ToString(kasa - kosztKoszyka()));
            Console.WriteLine("********************************************");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("********************************************");
            listaProduktow.Clear();

        }
        
    }
}
