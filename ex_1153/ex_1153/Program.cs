using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());
            int p = 1;
            for (int i = 1;i <=N;i++)
            {
                p = p * i;
              
            }
            

            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
