using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int M, N,maior,menor;
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);
            int total = 0;

            maior = M;
            menor = N;
            if (N > M)
            {
                maior = N;
                menor = M;
            }
            while(M > 0 & N > 0)
            {
                for(int i = menor; i <= maior; i++)
                {
                    Console.Write(i+" ");
                    total = i + total;
                }
                Console.WriteLine("Sum=" + total);
                vet = Console.ReadLine().Split(' ');
                M = int.Parse(vet[0]);
                N = int.Parse(vet[1]);
                total = 0;
                maior = M;
                menor = N;
                if (N > M)
                {
                    maior = N;
                    menor = M;
                }
            }

            Console.ReadKey();

        }
    }
}
