using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, maior,  menor ,meio;
            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                menor = x;
                if (y < z)
                {
                    meio = y;
                    maior = z;
                }
                else
                {
                    maior = y;
                    meio = z;
                }
            }
            else if(y < z)
            {
                menor = y;
                if(z < x)
                {
                    meio = z;
                    maior = x;
                }
                else
                {
                    meio = x;
                    maior = z;
                }
                
            }
            else
            {
                menor = z;
                if (y < x )
                {
                    meio = y;
                    maior = x;
                }
                else
                {
                    meio = x;
                    maior = y;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
