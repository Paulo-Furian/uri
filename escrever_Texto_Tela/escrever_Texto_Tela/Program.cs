using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace saidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // sem quebra de linha no final
            Console.Write("Hello Word!");
            Console.Write("Good Moring!");
            Console.WriteLine();
            // com quebra de linha

            Console.WriteLine("Ola Mundo!");
            Console.WriteLine("Bom dia!!");

           

            // atriburi valor a variavel

            double x = 10.45687;

            Console.WriteLine(x);

            //limitar o numuro de casas de decimais

            Console.WriteLine(x.ToString("F3"));

            // para imprenir o numero com ponto ao em vez de virgula(ex: 10.4545)
            // deve se importar a blibioteca sing System.Globalization;
            Console.WriteLine(x.ToString("F3",CultureInfo.InvariantCulture));


            // concatenar varios elementos em um so comando "+"
            Console.WriteLine("RESULTADO = " + x);

            Console.WriteLine("abc1 " + "abc2 " + x + "acb3 ");

            Console.WriteLine(" volor do troco foi " +  x.ToString("F2 ") + "reais");

            // area do trapezio

            double area, b, B, h;
            float dois = 2f; 
            h = 5.0; // boas prticas qnd for double " ex 1.0" ; float "ex 5f"
            b = 6.0;
            B = 8.0;
            area = ((b+B)/dois) * h;
            /*qnd for fazer alguma conta q o resultado for doble as variavesr deve ser double tbm 
             *pois se for int o compilador do c# vai enteder q o usuario vai querer valor inteiro 
             * 
             * outraa forma de solucionar esse problema e usando casting q é a conversao implicita de um 
             * tipo para outro
             * 
             * É necessário quando o compilador não é capaz de “adivinhar” que o 
             * resultado de uma expressão deve ser de outro tipo.
             * para isso e so colocar o tipo de conversao na frente da formula


            */
            int a, t;
            double resultado;
            a = 5;
            t = 2;

            resultado =  (double) a / t;

            // ex 2

            int w;
            double o = 5.0;

            w = (int) o;


            Console.WriteLine("Area do trapezio é: " + area);




            Console.ReadKey();
        }
    }
}
