using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    internal class Biegacz : Sportowiec
    {
        private bool wynik = true;

        public void CzyZawody()
        {
            if (this.wynik == true)
            {
                Console.WriteLine("Zawodnik kwalifikuje sie na zawody!");
            }
            else
            {
                Console.WriteLine("Zawodnik nie kwalifikuje sie na zawody!");
            }
        }

        public Biegacz()
        {
        }

        public void DajDane(string imie, string nazwisko, bool start)
        {
            Console.WriteLine("Imie: {0} ", imie);
            Console.WriteLine("Nazwisko: {0}", nazwisko);
            this.wynik = start;
        }
    }
}