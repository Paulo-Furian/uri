using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, p =0, i=0, n=0, ps=0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            if(a % 2 == 0) // par
            {
                p++;
                if(a > 0) // positivo
                {
                    ps++;
                }
                else if (a < 0)// negativo
                {
                    n++;
                }
            }
            else // impar
            {
                i++;

                if (a > 0) // positivo
                {
                    ps++;
                }
                else if (a < 0)// negativo
                {
                    n++;
                }
            }
            if (b % 2 == 0) // par
            {
                p++;
                if (b > 0) // positivo
                {
                    ps++;
                }
                else if (b < 0)// negativo
                {
                    n++;
                }
            }
            else // impar
            {
                i++;

                if (b > 0) // positivo
                {
                    ps++;
                }
                else if (b < 0) // negativo
                {
                    n++;
                }
            }
            if (c % 2 == 0) // par
            {
                p++;
                if (c > 0) // positivo
                {
                    ps++;
                }
                else if (c < 0)// negativo
                {
                    n++;
                }
            }
            else // impar
            {
                i++;

                if (c > 0) // positivo
                {
                    ps++;
                }
                else if(c < 0) // negativo
                {
                    n++;
                }
            }
            if (d % 2 == 0) // par
            {
                p++;
                if (d > 0) // positivo
                {
                    ps++;
                }
                else if (d < 0) // negativo
                {
                    n++;
                }
            }
            else // impar
            {
                i++;

                if (d > 0) // positivo
                {
                    ps++;
                }
                else if (d < 0)// negativo
                {
                    n++;
                }
            }
            if (e % 2 == 0) // par
            {
                p++;
                if (e > 0) // positivo
                {
                    ps++;
                }
                else if (e < 0) // negativo
                {
                    n++;
                }
            }
            else // impar
            {
                i++;

                if (e > 0) // positivo
                {
                    ps++;
                }
                else if (e < 0) // negativo
                {
                    n++;
                }
            }
            Console.WriteLine(p + " valor(es) par(es)");
            Console.WriteLine (i + " valor(es) impar(es)");
            Console.WriteLine(ps + " valor(es) positivo(s)");
            Console.WriteLine(n + " valor(es) negativo(s)");
           
            
            Console.ReadKey( );
        }
    }
}
