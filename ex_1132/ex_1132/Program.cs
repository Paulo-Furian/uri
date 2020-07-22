using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int M,x, y,res=0,m ;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            M = x;
            m = y;
            if (y > x)
            {
                M = y;
                m = x;
            }

            for (int i = m;i<=M;i++)
            {
                if (i % 13 != 0)
                {
                    res = res + i;
                }   
            }

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
