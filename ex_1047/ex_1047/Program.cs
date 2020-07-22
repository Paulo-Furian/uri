using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrI, mI, hrF, mF;
            string[] vet = Console.ReadLine().Split(' ');

            hrI = int.Parse(vet[0]);
            mI = int.Parse(vet[1]);
            hrF = int.Parse(vet[2]);
            mF = int.Parse(vet[3]);

            hrI = hrI * 60 + mI;
            hrF = hrF * 60 + mF;

            int duracao;

            if ( hrI < hrF)
            {
                duracao = hrF - hrI;
            }
            else
            {
                duracao = (24 * 60 - hrI) + hrF;
            }

            int duracaoHr = duracao / 60;
            int duracaoMin = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHr + " HORA(S) E " + duracaoMin + " MINUTO(S)");



            Console.ReadKey();


        }
    }
}
