using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    internal class Sportowiec
    {
        protected string imie;
        protected string nazwisko;

        public Sportowiec()
        {
        }

        public Sportowiec(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}