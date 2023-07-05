using System;
using System.Globalization;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1040_Media3
    {
        public static void executar()
        {
            string[] valoresTxt = Console.ReadLine().Split();

            double[] valoresNum = new double[valoresTxt.Length];
            for (int i = 0; i < valoresTxt.Length; i++)
            {
                double.TryParse(valoresTxt[i], NumberStyles.Any, CultureInfo.InvariantCulture, out double valorConvertido);
                valoresNum[i] = valorConvertido;
            }

            double mediaPonderada = ((valoresNum[0] * 2) + (valoresNum[1] * 3) + (valoresNum[2] * 4) + (valoresNum[3] * 1)) / 10;

            Console.WriteLine($"Media: {Math.Round(mediaPonderada, 1, MidpointRounding.ToEven).ToString("N1")}");

            if (mediaPonderada >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (mediaPonderada < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double mediaExame = (mediaPonderada + notaExame) / 2;
                Console.WriteLine($"Nota do exame: {notaExame.ToString("N1")}");

                if (mediaExame >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine($"Media final: {Math.Round(mediaExame, 1, MidpointRounding.ToEven).ToString("N1")}");
            }

        }

        // 2.0 4.0 7.5 8.0
        // 6.4
    }
}
