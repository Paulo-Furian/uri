using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2,distancia;
            string[] vet1, vet2;

            vet1 = Console.ReadLine().Split(' ');
            vet2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(vet1[0]);
            y1 = double.Parse(vet1[1]);
            x2 = double.Parse(vet2[0]);
            y2 = double.Parse(vet2[1]);


            distancia = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.WriteLine(distancia.ToString("F4"));

            Console.ReadKey();
        }
    }
}
