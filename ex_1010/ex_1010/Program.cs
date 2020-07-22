using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int peca1, n1, peca2, n2;
            double valor1, valor2,vlrTotal;

            string[] vet1 = Console.ReadLine().Split(' ');

            peca1 = int.Parse(vet1[0]);
            n1 = int.Parse(vet1[1]);
            valor1 = double.Parse(vet1[2]);

            valor1 = n1 * valor1;

            string[] vet2 = Console.ReadLine().Split(' ');

            peca2 = int.Parse(vet2[0]);
            n2 = int.Parse(vet2[1]);
            valor2 = double.Parse(vet2[2]);

            valor2 *= n2;

            vlrTotal = valor1 + valor2;


            Console.WriteLine("VALOR A PAGAR: R$ " + vlrTotal.ToString("F2"),CultureInfo.CurrentCulture);





            Console.ReadKey();


        }
    }
}
