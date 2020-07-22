using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1090
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i =1;i<=n;i++)
            {

                string [] a = Console.ReadLine().Split(' ');
                int x = int.Parse(a[0]);
                int y = int.Parse(a[1]);

                int M = y;
                int mn = x;
                if (x > y)
                {
                     M = x;
                     mn = y;
                }
                int soma = 0;
                for (int j = mn+1; j < M; j++)
                {
                    if(j % 2 != 0)
                    {
                        soma += j;
                    }
                   
                }
                Console.WriteLine(soma);
            }

            Console.ReadKey();
        }
    }
}
