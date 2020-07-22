using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            int a = 1;
            for (int i = 1; i <= N; i++)
            {
                int b = a + 1;
                int c = a + 2;
                Console.WriteLine(a +" "+b+" "+c+" "+"PUM");

                a = a + 4;
            }

            Console.ReadKey();
        }
    }
}
