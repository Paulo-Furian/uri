using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ex_vet7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

               
               
                    nome[i] = s[0];
                    nota1[i] = double.Parse(s[1],CultureInfo.InvariantCulture);
                    nota2[i] = double.Parse(s[2],CultureInfo.InvariantCulture);


            }

            Console.WriteLine("ALunos Aprovados:");
            for (int q = 0; q < n; q++)
            {
                if ((nota1[q] + nota2[q]) / 2 >= 6.0)
                {

                    Console.WriteLine(nome[q]);

                }
                
            }

            Console.ReadKey();
        }
    }
}
