using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i =1;i<= N;i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x % x ==  0 && x % 1 == 0 )
                {
                    if (x % 2 == 0 || x % 3 == 0)
                    {
                        Console.WriteLine(x +" nao eh primo");
                    }
                    else
                    {
                        Console.WriteLine(x +" eh primo");
                    }
                }
               
            }
            Console.ReadKey();
        }
    }
}
