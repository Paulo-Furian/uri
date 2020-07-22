using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for(int i =2;i <= N; i++)
            {
                if (i % 2 == 0)
                {

                    int reslt = i * i;
                    Console.WriteLine(i + "^2 = " + reslt);
                }
              
            }

            Console.ReadKey();
        }
    }
}
