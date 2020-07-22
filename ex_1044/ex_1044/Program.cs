using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z;
            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            z = int.Parse(vet[1]);

         
            if ( z % x == 0 || x % z == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.ReadKey();
        }
    }
}
