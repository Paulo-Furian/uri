using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            double i;
            double a = 5.0;
            double b = 8.0;
            double c = 10.0;
            double d = -10.0;

            a = Math.Sqrt(a);
            i = Math.Sqrt(144.0);

            b = Math.Pow(b, 4);
            i = Math.Pow(5, 5);

            c = Math.Abs(d);
            d = Math.Abs(d);


            // baskara

            double delta, A, B, C, x1, x2;

            delta =(( Math.Pow(b, 2)) / -4 * A * B);

            x1 = ((-B + Math.Sqrt(delta)) / 2.0*A    ); 
            x2 = ((-B - Math.Sqrt(delta)) / 2.0*A    ); 
        }
    }   
}
