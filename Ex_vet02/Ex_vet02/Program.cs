using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_vet02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] s = new string[N];
            int[] vet = new int[N];
            int qtd =0;
            s = Console.ReadLine().Split(' ');

            for (int i = 0; i <N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }
            for (int i = 0; i <N; i++)
            {
                if (vet[i]/2.0 == 0.0 )
                {
                    Console.WriteLine(vet[i]);
                }
            }
            Console.WriteLine(qtd);
            Console.ReadKey();
        }
    }
}
