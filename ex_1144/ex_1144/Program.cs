using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j =1;j<=2;j++)
                {
                    int a = i;
                    if (j != 2)
                    {
                        int b = i * i;
                        int c = i * i * i;
                        Console.WriteLine(a + " " + b + " " + c);
                    }
                    else
                    {
                        int b = i * i + 1;
                        int c = i * i * i+1;
                        Console.WriteLine(a + " " + b + " " + c);
                    }

                }
            }

            Console.ReadKey();
            

        }
    }
}
