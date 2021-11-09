using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_sa
{
    class Zadanie2
    {
        public int[] CiagFibi(int dlugosc)
        {

            int[] ciag = new int[dlugosc];
            ciag[0] = 0;
            ciag[1] = 1;

            for (int i = 2; i < dlugosc; i++)
            {
                ciag[i] = ciag[i - 2] + ciag[i - 1];
            }
            return ciag;

        }
        public static void WyswietlCiag(int start, int ilosc, int[] ciag)
        {
            int dlugoscC = start + ilosc-1;
            for (int j = start -1; j < dlugoscC; j++)
            {
                Console.Write(ciag[j] + " ");
            }
        }
        public void Zad2Run()
        {
            Console.WriteLine("************* Zadanie 2 ****************");
            Console.WriteLine("Podaj pierwszy element ciągu");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ilość elementów do wyświetlenia zaczynając od pierwszego elementu");
            int ilosc = Convert.ToInt32(Console.ReadLine());
            int dlugosc = start + ilosc-1;
            int[] ciagWys = CiagFibi(dlugosc);
            WyswietlCiag(start, ilosc, ciagWys);
            Console.WriteLine("");
        }

    }
}
