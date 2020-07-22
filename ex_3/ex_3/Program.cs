using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double bs, altura,area ,pert,diag;

            bs = double.Parse(Console.ReadLine()); 
            altura = double.Parse(Console.ReadLine());

            area = bs * altura;
            pert = 2 * (altura + bs);

            diag = Math.Sqrt(Math.Pow(bs, 2) + Math.Pow(altura, 2));

            Console.WriteLine("Area = " + area);
            Console.WriteLine("PERIMETRO = " + pert);
            Console.WriteLine("DIAGONAL = " + diag);

            Console.ReadKey();
        }
    }
}
