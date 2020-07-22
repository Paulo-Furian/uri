using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_Vet01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] s = new string[N];
            double[] vet = new double[N];
            double maior = 0.0;
            int posi=0;
            s = Console.ReadLine().Split(' ');
            for (int i = 0; i <N;i++)
            {
                vet[i] = double.Parse(s[i],CultureInfo.InvariantCulture);
            }

            for (int i =0; i <N;i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posi = i;
                }
            }

            Console.WriteLine(""+ maior +"");
            Console.WriteLine(""+ posi +"");

            Console.ReadKey();
        }

    }
}
