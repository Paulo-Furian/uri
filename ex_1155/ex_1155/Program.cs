using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 1 ;

            for (float i = 2; i <= 100; i++)
            {
                s += 1 / i;

                
            }
            Console.WriteLine(s.ToString("F2"));

        }
    }
}
