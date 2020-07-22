using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ex_1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double x = double.Parse(vet[0],CultureInfo.InvariantCulture);
                double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double res = x / y;
                    Console.WriteLine(res.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
            Console.ReadKey();
        }
    }
}
