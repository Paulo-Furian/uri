using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            MEDIA = (A * 3.5 + B * 7.5)/(3.5 + 7.5);

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));

            Console.ReadKey();
        }
    }
}
