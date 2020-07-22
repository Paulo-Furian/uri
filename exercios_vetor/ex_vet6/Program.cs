using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_vet6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string nomeMaior = "p";
            int idMaior =0;
            string[] nome = new string[a];

            for (int i = 0; i < a; i++)
            {
                nome[i] = Console.ReadLine();
            }

            int[] idade = new int[a];

            for(int i = 0; i < a; i++)
            {
                idade[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i < a; i++)
            {
                if (idade[i] >= idMaior)
                {
                    idMaior = idade[i];
                    nomeMaior = nome[i];
                }
            }
            Console.WriteLine("Pessoa mais velha: "+ nomeMaior);

        }
    }
}
