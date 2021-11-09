using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_sa
{
    class Zadanie1
    {
               public void Zad1Run() 
        {
            Console.WriteLine("************* Zadanie 1 ****************");
            Console.WriteLine("Podaj długość ciągu - ilość elementów");
            int dlugosc = Convert.ToInt32(Console.ReadLine());
            int[] ciag = new int[dlugosc];
            ciag[0] = 0;
            ciag[1] = 1;

            for (int i = 2; i < dlugosc; i++)
            {
                ciag[i] = ciag[i - 2] + ciag[i - 1];
            }
            for (int j = 0; j < ciag.Length; j++)
            {
                Console.Write(ciag[j] + " ");
            }
            Console.WriteLine("");

        }       
    }
}
