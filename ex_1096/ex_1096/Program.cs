﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1096
{
    class Program
    {
        static void Main(string[] args)
        {
        for(int i = 1; i <= 9; i += 2)
            {
                for (int j = 7; j >= 5; j--)
                {

                    Console.Write("I=" + i + " J=" + j + "\n");
                }
            }

            Console.ReadKey();


        }
    }
}
