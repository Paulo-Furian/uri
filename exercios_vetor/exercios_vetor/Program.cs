using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercios_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double[] N = new double[a];
            double maior = 0.0;
            int posi =0;
            string[] v;

            v = Console.ReadLine().Split(' ');
            for (int i =0; i<a;i++ )
            {
                N[i] = double.Parse(v[i],CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < a;i++ )
            {
               
               
                if(N[i] > maior)
                {
                    maior = N[i];
                    posi = i;
                }


            }
            Console.WriteLine(maior.ToString("f1",CultureInfo.InvariantCulture));
            Console.WriteLine(posi.ToString("f1",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
