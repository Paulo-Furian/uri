using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            for (int i = 1; x >= i; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }


            }

            Console.ReadKey();
        }
    }
}
