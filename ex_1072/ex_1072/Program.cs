using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x,In = 0,Out = 0;

            N = int.Parse(Console.ReadLine());

            for (int i =1;i <= N;i++)
            {
                x = int.Parse(Console.ReadLine());

                if(x >= 10 && x <= 20)
                {
                    In++;
                }
                else
                {
                    Out++;
                }
            }
            Console.WriteLine(In + " in");
            Console.WriteLine(Out+" out");

            Console.ReadKey();
        }
    }
}
