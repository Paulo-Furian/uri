using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ex_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, area, perimetro;
            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0],CultureInfo.InvariantCulture);
            B = double.Parse(vet[1],CultureInfo.InvariantCulture);
            C = double.Parse(vet[2],CultureInfo.InvariantCulture);

            if (A + B > C && B+C > A && C+A > B)
            {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = "+perimetro.ToString("F1",CultureInfo.InvariantCulture));

            }
            else
            {
                area = ((A + B) * C) / 2.0;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();

        }
    }
}
