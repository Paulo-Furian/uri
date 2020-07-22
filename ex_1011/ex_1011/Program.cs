using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume;
            int R;
            double pi = 3.14159;

            R = int.Parse(Console.ReadLine());

            volume = (4  * pi * Math.Pow(R, 3)) / 3;

            Console.WriteLine("VOLUME = " +volume.ToString("F3"));

            Console.ReadKey();
        }
    }
}
