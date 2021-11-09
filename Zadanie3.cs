using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_sa
{
    class Zadanie3
    {
        public void CalkaKwadratyLewe(double poczatek, double koniec, int lPrzedzialow)
        {
            double powierzchnia = 0;
            double x = poczatek;
            double krok = ((double)koniec - (double)poczatek) / (double)lPrzedzialow;
            for (int i = 1; i <= lPrzedzialow; i++)
            {                
                powierzchnia += WzorFunkcji(x) * krok;
                x += krok;
            }
            Console.WriteLine("Przybliżona wartość całki przy wariancie lewych kwadratów :" + powierzchnia);
        }
        public void CalkaKwadratySrodkowe(double poczatek, double koniec, int lPrzedzialow)
        {
            double powierzchnia = 0;
            double krok = ((double)koniec - (double)poczatek) / (double)lPrzedzialow;
            double x = poczatek + krok / 2;

            for (int i = 1; i <= lPrzedzialow; i++)
            {
                powierzchnia += WzorFunkcji(x)*krok;
                x += krok;
            }
           
            Console.WriteLine("Przybliżona wartość całki przy wariancie środkowych kwadratów :" + powierzchnia);
        }
        public void CalkaKwadratyPrawe(double poczatek, double koniec, int lPrzedzialow)
        {
            double powierzchnia = 0;
            
            double krok = ((double)koniec - (double)poczatek) / (double)lPrzedzialow;
            double x = poczatek + krok;


            for (int i = 1; i <= lPrzedzialow; i++)
            { 
                powierzchnia += WzorFunkcji(x) * krok;
                x += krok;

            }
            Console.WriteLine("Przybliżona wartość całki przy wariancie prawych kwadratów :" + powierzchnia);
        }

        public static double WzorFunkcji(double x)
        {
            return (double)1 / (double)2 * (double)x;
        }
        public void Zad3Run()
        {
            Console.WriteLine("************* Zadanie 3 ****************");
            Console.WriteLine("Podaj początek przedziału");
            double poczatek = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj koniec przedziału");
            double koniec = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbę przedziałów");
            int lPrzedzialow = Convert.ToInt32(Console.ReadLine());
            CalkaKwadratyLewe(poczatek, koniec, lPrzedzialow);
            CalkaKwadratySrodkowe(poczatek, koniec, lPrzedzialow);
            CalkaKwadratyPrawe(poczatek, koniec, lPrzedzialow);
            Console.WriteLine("");
        }
    }
}
