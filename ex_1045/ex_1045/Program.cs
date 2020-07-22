using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ex_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, x;
            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);








            if (A < B || A < C)
            {
                x = A;
                A = B;
                B = x;
                if (A < C)
                {
                    x = A;
                    A = C;
                    C = x;

                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");

            }
            else if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }

            }
            else if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }

            Console.ReadKey();
        }
    }
}
