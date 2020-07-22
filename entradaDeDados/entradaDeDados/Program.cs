using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace entradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // para ler um texto (ate a quebra de linha)
            string x;
            x = Console.ReadLine();

            // para ler um numero inteiro

            int n;

            n = int.Parse(Console.ReadLine());

           //n = Convert.ToInt16(Console.ReadLine());

            // para ler um numero com ponto flutante

            float p;
            double w;

            p = float.Parse(Console.ReadLine());

            w = double.Parse(Console.ReadLine());

            // para usar o ponto ao em vez da virgula

            p = float.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            // para ler um caracter

            char c;
            c = char.Parse(Console.ReadLine());



            Console.WriteLine(x);
            Console.WriteLine(n);
            Console.WriteLine(p);
            Console.WriteLine(w);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
