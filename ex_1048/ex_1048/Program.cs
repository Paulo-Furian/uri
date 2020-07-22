using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste,pcento;

            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (salario > 0.00 && salario <= 400.00)
            {
                pcento = 0.15;
                reajuste = salario * pcento;// reajuste
                salario = reajuste + salario; // novo salario
                pcento *= 100;

            }
            else if (salario >= 400.01 &&  salario <=800.00 )
            {
                pcento = 0.12;
                reajuste = salario * pcento;// reajuste
                salario = reajuste + salario; // novo salario
                pcento *= 100;
            }
            else if (salario >= 800.01 && salario <=1200.00)
            {
                pcento = 0.10;
                reajuste = salario * pcento;// reajuste
                salario = reajuste + salario; // novo salario
                pcento *= 100;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                pcento = 0.07;
                reajuste = salario * pcento;// reajuste
                salario = reajuste + salario; // novo salario
                pcento *= 100;
                
            }
            else
            {
                pcento = 0.04;
                reajuste = salario * pcento;// reajuste
                salario = reajuste + salario; // novo salario
                pcento *= 100;
            }

            Console.WriteLine("Novo salario: "+salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: "+ reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: "+ pcento +" %");

            Console.ReadLine();
        }
    }
}
