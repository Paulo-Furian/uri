using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double larg, compr,area, vlr;

            Console.WriteLine("Escreva a largura o comprimento e o valor do terreno por metro quadrado: ");


            string[] vet = Console.ReadLine().Split(' ');

            larg = double.Parse(vet[0]);

            compr = double.Parse(vet[1]);
            vlr = double.Parse(vet[2]);

            area = larg * compr;
            vlr = area * vlr;

            Console.WriteLine("Area total: " + area);
            Console.WriteLine("Valor total: " + vlr);

            Console.ReadKey();

        }
    }
}
