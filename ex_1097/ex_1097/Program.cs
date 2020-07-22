using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int p=7,j,x=5;
            for(int i = 1; i <= 9; i += 2)
            {
               
                for( j=p ; j>=x ; j-- )
                { 
                    
                    Console.WriteLine("I="+i + " J="+j);
                    
                }
                p += 2;
                x += 2;
            }
            Console.ReadKey();
        }
    }
}
