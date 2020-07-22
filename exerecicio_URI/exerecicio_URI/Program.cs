using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exerecicio_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFuncionario, hrTrabahadas;
            double vlrHr;

            nFuncionario = int.Parse(Console.ReadLine());
            hrTrabahadas = int.Parse(Console.ReadLine());
            vlrHr = double.Parse(Console.ReadLine());

            vlrHr = hrTrabahadas * vlrHr;
            

            Console.WriteLine("NUMBER = " + nFuncionario);
            Console.WriteLine("SALARY = $" + vlrHr.ToString("F2"));

            Console.ReadKey();
        }
    }
}
