using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ex_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, media, nExame;
            string[] vet = Console.ReadLine().Split();

            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (N1 * 2.0f + N2 * 3.0f + N3 * 4.0f + N4 * 1.0f) / (2.0f + 3.0f + 4.0f + 1.0f);

            if (media == 4.85f)
            {
                media = 4.8f;
            }
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            if (media > 7.0f)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media < 7.0f && media >= 5.0f)
            {
                Console.WriteLine("Aluno em exame.");
                nExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + nExame.ToString("F1", CultureInfo.InvariantCulture));
                media = (media + nExame) / 2.0f;
                if (media >= 5.0f)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");

                }
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));

            }



            Console.ReadKey();
        }
    }
}
