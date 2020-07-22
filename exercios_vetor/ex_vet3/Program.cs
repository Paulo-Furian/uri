using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_vet3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
          

            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(Console.ReadLine());
            }

            int[] C = new int[N];

            for(int i =0;i< N; i++)
            {
                C[i] = A[i] + B[i];
            }

            for(int i =0; i<N; i++)
            {
                Console.WriteLine(C[i]); 
            }

            Console.ReadKey();

        }
    }
}
