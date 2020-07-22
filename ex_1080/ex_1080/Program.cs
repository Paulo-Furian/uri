using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maior = 0,posi = 0;
            
            for(int i = 1;i <= 100; i++)
            {
                n = int.Parse(Console.ReadLine());
               if(n > maior)
                {
                    maior = n;
                    posi = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posi);

            Console.ReadKey();
        }
    }
}
