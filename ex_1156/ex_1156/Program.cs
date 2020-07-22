using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1156
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 1.0;
            
            for (double i = 2.0, b = 3.0 ; b <= 39.0; i *= 2, b+=2)
            {
                s += b/ i;

            }
            Console.WriteLine(s.ToString("F2"));
        }
    }
}
