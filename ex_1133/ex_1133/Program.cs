using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y,M,m;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            M = x;
            m = y;
            if (y > x)
            {
                M = y;
                m = x;
            }
            m += 1;
            for (int i =m;m<M;m++ )
            {
                if(m %5 ==2 || m % 5 == 3)
                {
                    Console.WriteLine(m);
                }
            }

            Console.ReadKey();
        }
    }
}
