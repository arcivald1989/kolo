using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    internal class Pilkarz : Sportowiec
    {
        private int iloscBramek;

        public void StrzelGola()
        {
            this.iloscBramek++;
        }

        public void WyswietlBramki()
        {
            Console.WriteLine("Ilosc bramek: {0}", iloscBramek);
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imie: {0}", imie);
            Console.WriteLine("Nazwisko: {0}", nazwisko);
        }

        public Pilkarz(string imie, string nazwisko, int iloscBramek)
            : base(imie, nazwisko)
        {
            this.iloscBramek = iloscBramek;
        }
    }
}