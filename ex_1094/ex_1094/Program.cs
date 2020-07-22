using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, S = 0, C = 0, R = 0, qnt, total = 0;
            double tC, tS, tR;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] test = Console.ReadLine().Split(' ');
                qnt = int.Parse(test[0]);
                string tipo = test[1];

                switch (tipo)
                {
                    case "C":
                        C = qnt + C;
                        break;
                    case "R":
                        R = qnt + R;
                        break;
                    case "S":
                        S = qnt + S;
                        break;

                }

                total = C + R + S;

            }
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + C);
            Console.WriteLine("Total de ratos: " + R);
            Console.WriteLine("Total de sapos: " + S);
            tC = (double)(C * 100) / total;
            Console.WriteLine("Percentual de coelhos: " + tC.ToString("F2") + " %");
            tR = (double)(R * 100) / total;
            Console.WriteLine("Percentual de ratos: " + tR.ToString("F2") + " %");
            tS = (double)(S * 100) / total;
            Console.WriteLine("Percentual de sapos: " + tS.ToString("F2") + " %");

            Console.ReadKey();
        }
    }
}
