using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B,C, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            MEDIA = (A * 2 + B * 3 + C * 5) / (2 + 3 + 5);

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));

            Console.ReadKey();
        }
    
    }
}
