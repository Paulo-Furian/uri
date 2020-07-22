using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qnt;
            double vlr;
            string[] vet = Console.ReadLine().Split(' ');


            cod = int.Parse(vet[0]);
            qnt = int.Parse(vet[1]);

            switch (cod)
            {
                case 1:
                    vlr = qnt * 4.00;
                    Console.WriteLine("Total: R$ " + vlr.ToString("F2",CultureInfo.InvariantCulture));
                    break;
                case 2:
                    vlr = qnt * 4.50;
                    Console.WriteLine("Total: R$ " + vlr.ToString("F2", CultureInfo.InvariantCulture));

                    break;


                case 3:
                    vlr = qnt * 5.00;
                    Console.WriteLine("Total: R$ " + vlr.ToString("F2", CultureInfo.InvariantCulture));

                    break;
                case 4:
                    vlr = qnt * 2.00;
                    Console.WriteLine("Total: R$ " + vlr.ToString("F2", CultureInfo.InvariantCulture));

                    break;
                case 5:
                    vlr = qnt * 1.50;
                    Console.WriteLine("Total: R$ " + vlr.ToString("F2", CultureInfo.InvariantCulture));

                    break;

             


                }

            Console.ReadKey();


        }
    }
}
