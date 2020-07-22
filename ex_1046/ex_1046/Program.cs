using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] x = Console.ReadLine().Split(' ');
           int hrInicial = int.Parse(x[0]);
           int hrFinal = int.Parse(x[1]);
            int Duracao;
            if (hrInicial > hrFinal)
            {
                Duracao = 24 - hrInicial + hrFinal;

            }
            else if( hrInicial == hrFinal)
            {
                Duracao = 24;
            }
            else
            {
                Duracao = hrFinal - hrInicial;

            }

            
            Console.WriteLine("O JOGO DUROU " + Duracao + " HORA(S)");
            Console.ReadKey();

        }
    }
}
