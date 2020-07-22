using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ex_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f, i = 0,media = 0;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a > 0.0)
            {
                i++;
                media =media + a;
            }
            if (b > 0.0)
            {
                i++;
                media = media + a;
            }
            if (c > 0.0)
            {
                i++;
                media = media + a;
            }
            if (d > 0.0)
            {
                i++;
                media = media + a;
            }
            if (e > 0.0)
            {
                i++;
                media = media + a;
            }
            if (f > 0.0)
            {
                i++;
                media = media + a;
            }

            media = media / i;
            Console.WriteLine(i + " valores positivos");
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}
