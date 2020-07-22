using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse( Console.ReadLine());
            string[] vet = new string [n];
            for (int i = 0; i< n; i++) {

                vet[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vet[i]);
            }

            foreach (string elemento in vet)
            {
                Console.WriteLine(elemento);
            }
        }

    }
}
