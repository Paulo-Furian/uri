using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1020
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, dia, mes, ano, r;
            N = int.Parse(Console.ReadLine());

            ano = N / 365;
            r = N % 365;
            mes = r / 30;
            dia = r % 30;
           
           
            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");


            Console.ReadKey();





        }
    }
}
