using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_sa
{
    class Zadanie7
    {       

        
        public double CalkaTrapezy(double poczatek, double koniec, int lPrzedzialow)
        {
            double powierzchnia = 0;

            double krok = ((double)koniec - (double)poczatek) / (double)lPrzedzialow;
            double x = poczatek;


            for (int i = 1; i < lPrzedzialow; i++)
            {
               powierzchnia += WzorFunkcji(poczatek + i * krok);
            }
            powierzchnia = (powierzchnia + (WzorFunkcji(poczatek) + WzorFunkcji(koniec)) / 2) * krok;
            /*            Console.WriteLine("Przybliżona wartość całki metodą trapezów :" + powierzchnia);*/
            return powierzchnia;
        }

        public static double WzorFunkcji(double x)
        {
            return Math.Sin(x);
        }
        public void Zad7Run()
        {
            Console.WriteLine("************* Zadanie 7 ****************");
            Console.WriteLine("Obliczenia całki dla funkji sin(x) w przedziale 0 - 2Pi");
            double poczatek = 0;  
            double koniec = Math.PI;
            double koniec2 = 2 * Math.PI;
            Console.WriteLine("Podaj liczbę przedziałów");
            int lPrzedzialow = Convert.ToInt32(Console.ReadLine());
            double calkaSinus = CalkaTrapezy(poczatek, koniec, lPrzedzialow) + CalkaTrapezy(koniec, koniec2, lPrzedzialow);
            double powierzchniaSinus = CalkaTrapezy(poczatek, koniec, lPrzedzialow) - CalkaTrapezy(koniec, koniec2, lPrzedzialow);
            calkaSinus = Math.Round(calkaSinus, 4);
            Console.WriteLine("Przybliżona wartość całki wynosi :" + calkaSinus);
            Console.WriteLine("Przybliżona powierzhcnia figury ograniczonej przez wykres funkcji wynosi :" + powierzchniaSinus);
            Console.WriteLine("");
        }
    }
}
