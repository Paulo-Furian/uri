using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string tp1, tp2, tp3;

            tp1 = Console.ReadLine();
            tp2 = Console.ReadLine();
            tp3 = Console.ReadLine();

            if (tp1 == "vertebrado")
            {
                if (tp2 == "ave") //se for ave
                {
                    if (tp3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else // se nao entao mamifero
                {
                    if (tp3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else // se nao entao invertebrado
            {
                if (tp2 == "inseto")
                {
                    if (tp3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (tp3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }


            Console.ReadKey();

        }
    }
}
