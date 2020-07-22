
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex_vet5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] N = new int[a];
            double media =0;
            int d = 0;
            string[] s;

            s = Console.ReadLine().Split(' ');
            for(int i = 0; i < a; i++)
            {
                N[i] = int.Parse(s[i]);
            }
            for (int i =0;i<a;i++)
            {
                if(N[i] % 2 == 0)
                {
                    media += N[i];
                    d++;
                }
            }
            media = (double)media / d;
            Console.WriteLine(media.ToString("f1",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
