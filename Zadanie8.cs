using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_sa
{
    class Zadanie8
    {
        public void CalkaTrapezy(double poczatek, double koniec, int lPrzedzialow, double a, double b, double c)
        {
            double powierzchnia = 0;
            double krok = ((double)koniec - (double)poczatek) / (double)lPrzedzialow;
            double x = poczatek;

            for (int i = 1; i < lPrzedzialow; i++)
            {
                powierzchnia += WzorFunkcji(poczatek + i * krok, a, b, c);
            }
            powierzchnia = (powierzchnia + (WzorFunkcji(poczatek, a, b, c) + WzorFunkcji(koniec, a, b, c)) / 2) * krok;
            Console.WriteLine("Przybliżona wartość całki metodą trapezów :" + powierzchnia);
        }

        public static double WzorFunkcji(double x, double a, double b, double c)
        {
            return a * x * x + b * x + c;
        }
        public void Zad8Run()
        {
            Console.WriteLine("************* Zadanie 8 ****************");
            Console.WriteLine("Obliczenia całki dla funkji y=ax*x+bx+c");
            Console.WriteLine("Podaj a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj początek przedziału");
            double poczatek = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj koniec przedziału");
            double koniec = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbę przedziałów");
            int lPrzedzialow = Convert.ToInt32(Console.ReadLine());
            CalkaTrapezy(poczatek, koniec, lPrzedzialow, a, b, c);
        }
    }
}
