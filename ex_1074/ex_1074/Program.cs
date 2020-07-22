using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;

            n = int.Parse(Console.ReadLine());

            for(int i = 1; i<= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("NULL");
                    
                }
                else if(x % 2 ==0)
                {
                    if(x > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                        
                    }
                    else
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                        
                    }
                }
                else
                {
                    if(x % 2 != 0)
                    {
                        if (x > 0)
                        {
                            Console.WriteLine("ODD POSITIVE");
                            
                        }
                        else
                        {
                            Console.WriteLine("ODD NEGATIVE");
                            
                        }
                    } 
                }
            }

            Console.ReadKey();
        }  
    }
}

