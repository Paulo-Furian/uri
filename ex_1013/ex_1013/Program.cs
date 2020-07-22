using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorab, maior;
            string [] vet;
            vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            maiorab = (a + b + Math.Abs(a - b))/2;

            maior = (maiorab + c + Math.Abs(maiorab - c))/2;

            Console.WriteLine(maior + " eh o maior");

            Console.ReadKey();

  
           


        }
    }
}
