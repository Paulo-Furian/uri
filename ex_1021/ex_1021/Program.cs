using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, resto, total, moeda; ;
            int nota;
            N = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            nota = 100;

            total =  N / nota;
            resto = N % nota;
            Console.WriteLine("NOTAS:");
            Console.WriteLine((int) total + " nota(s) de R$ " + nota + ".00");

            nota = 50;
            total = resto / nota;
            resto = resto % nota;

            Console.WriteLine((int) total + " nota(s) de R$ " + nota + ".00");

            nota = 20;
            total = resto / nota;
            resto = resto % nota;
            Console.WriteLine((int)total + " nota(s) de R$ " + nota+ ".00");

            nota = 10;
            total = resto / nota;
            resto = resto % nota;
            Console.WriteLine((int) total + " nota(s) de R$ " + nota + ".00");

            nota = 5;

            total = resto / nota;
            resto = resto % nota;
            Console.WriteLine((int) total + " nota(s) de R$ " + nota + ".00");

            nota = 2;

            total = resto / nota;
            resto = resto % nota;
            Console.WriteLine((int) total + " nota(s) de R$ " + nota + ".00");                                                                                                                                                                                                                                                                                                      

            Console.WriteLine("MOEDAS:");

            moeda = 1;
            total = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)total + " moeda(s) de R$ " + moeda + ".00");

            moeda = 0.50;
            total = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)total + " moeda(s) de R$ " + moeda.ToString("F2",CultureInfo.InvariantCulture));

            moeda = 0.25;   
            total = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)total + " moeda(s) de R$ " + moeda.ToString(CultureInfo.InvariantCulture));

            moeda = 0.10;
            total = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)total + " moeda(s) de R$ " + moeda.ToString("F2",CultureInfo.InvariantCulture));

             moeda = 0.05;
            total = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)total + " moeda(s) de R$ " + moeda.ToString(CultureInfo.InvariantCulture));

            moeda =Math.Round( 0.01);
            total = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine((int)total + " moeda(s) de R$ " + moeda.ToString(CultureInfo.InvariantCulture));



            Console.ReadKey();






        }
    }
}
