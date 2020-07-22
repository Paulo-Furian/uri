using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas, salariott ;

            Console.WriteLine("primeiro nome do vendedor");

            nome = Console.ReadLine();

            vendas = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            salario = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            salariott = vendas + (0.15 * salario);

            Console.WriteLine("TOTAL = R$ "+ salariott.ToString("F2"),CultureInfo.CurrentCulture);


            Console.ReadKey();


        }
    }
}
