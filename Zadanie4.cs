using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_sa
{
    class Zadanie4
    {
        public void CalkaKwadratySrodkowe(double poczatek, double koniec, int lPrzedzialow)
        {
            double powierzchnia = 0;
            double krok = ((double)koniec - (double)poczatek) / (double)lPrzedzialow;
            double x = poczatek + krok / 2;

            for (int i = 1; i <= lPrzedzialow; i++)
            {
                powierzchnia += WzorFunkcji(x) * krok;
                x += krok;
            }
            Console.WriteLine("Przybliżona wartość całki przy wariancie środkowych kwadratów :" + powierzchnia + " przy liczbie przedziałów " + lPrzedzialow);
        }
        public static double WzorFunkcji(double x)
        {
            return (double)1 / (double)2 * (double)x;
        }
        public void Zad4Run()
        {
            Console.WriteLine("************* Zadanie 4 ****************");
            Console.WriteLine("Podaj poczatkową ilość elementów");
            int lPrzedzialowBadanieStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj końcową liczbę elementów");
            int lPrzedzialowBadanieKoniec = Convert.ToInt32(Console.ReadLine());
            for (int i = lPrzedzialowBadanieStart; i <= lPrzedzialowBadanieKoniec; i++)
            {
                CalkaKwadratySrodkowe(0, 2, i);
            }
            Console.WriteLine("");
            Console.WriteLine("Na podstawie wyników możemy stwierdzić, że błąd wyznaczania wartości całki maleje wraz z kwadratem długości odcinków, na które dzielimy przedział czyli liczbą elementów");
            Console.WriteLine("");
        }
    }
}
