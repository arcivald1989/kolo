using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Pilkarz arek = new Pilkarz("Arek", "Dogiel", 4);
            Pilkarz domin = new Pilkarz("Domin", "Laskowski", 8);

            for (int i = 1; i <= 2; i++)
            {
                arek.StrzelGola();
                domin.StrzelGola();
            }

            arek.WypiszInfo();
            arek.WyswietlBramki();
            domin.WypiszInfo();
            domin.WyswietlBramki();

            Biegacz jarek = new Biegacz();
            jarek.DajDane("Jarek", "Gosc", true);
            jarek.CzyZawody();
            Console.ReadKey();
        }
    }
}