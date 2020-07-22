

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercio__vetor_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] N = new int[a];
            int j=0;
            for (int i =0; i<a;i++ )
            {
                N[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < a; i++)
            {
                if(N[i] % 2 == 0)
                {
                    Console.Write(N[i]+ " ");
                     j++;
                }
            }
            Console.WriteLine(j);

            Console.ReadKey();
        }
    }
}
