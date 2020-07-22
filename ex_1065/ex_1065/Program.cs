using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, p =0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            if(a % 2 == 0)
            {
                p++;
            }
            if(b % 2 == 0)
            {
                p++;
            }
            if ( c % 2 == 0)
            {
                p++;
            }
            if (d % 2 == 0)
            {
                p++;
            }
            if (e % 2 == 0)
            {
                p++;
            }

            Console.WriteLine(p + " valores pares");
            Console.ReadKey();
        }
    }
}
