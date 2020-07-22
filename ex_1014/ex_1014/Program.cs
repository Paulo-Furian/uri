using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, consMedio;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            consMedio = x / y;

            Console.WriteLine(consMedio.ToString("F3") + " km/l");

            Console.ReadKey();
        }
    }
}
