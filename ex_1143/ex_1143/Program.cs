using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for(int i= 1;i <= N; i++)
            {
                int a = i;
                int b = i * i;
                int c = i * i * i;

                Console.WriteLine(a+" "+b+" "+c);
            }
            Console.ReadKey();
        }
    }
}
