using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int PA, PB;
            double G1, G2;
            int anos =0 ;
            for (int i = 1; i <= T; i++)
            {
                string[] teste = Console.ReadLine().Split(' ');
                PA = int.Parse(teste[0]);
                PB = int.Parse(teste[1]);
                G1 = double.Parse(teste[2], CultureInfo.InvariantCulture);
                G2 = double.Parse(teste[3], CultureInfo.InvariantCulture);
                double pa = PA;
                double pb = PB;
 
                while (pa <=pb)
                {
                    pa +=(int)( pa * (G1 / 100));
                    pb += (int)( pb * (G2 / 100));
                    anos++;
                }


                Console.WriteLine(anos);

            }

            Console.ReadKey();
        }
    }
}
