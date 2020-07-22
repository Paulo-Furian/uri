using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, horas, mim, seg, resto ;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            mim = resto / 60;
            seg = resto % 60;

            Console.WriteLine(horas + ":" + mim + ":" + seg);

            Console.ReadKey();


        }
    }
}
