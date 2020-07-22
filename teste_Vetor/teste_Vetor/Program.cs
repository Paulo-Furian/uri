using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int id;
            string nome;
            double peso;

            string[] vet = Console.ReadLine().Split(' ');

            id = int.Parse(vet[0]);
            nome = vet[1];
            peso = double.Parse(vet[2]);


            



            Console.WriteLine(id +' '+ nome + peso );

            Console.ReadKey();
        }
    }
}
