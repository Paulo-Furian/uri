using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ex_1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f, i = 0;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a > 0.0)
            {
                i++;
            }
            if (b > 0.0)
            {
                i++;
            }
            if (c > 0.0)
            {
                i++;
            }
            if (d > 0.0)
            {
                i++;
            }
            if (e > 0.0)
            {
                i++;
            }
            if (f > 0.0)
            {
                i++;
            }

            Console.WriteLine(i + " valores positivos");


        }
    }
}
