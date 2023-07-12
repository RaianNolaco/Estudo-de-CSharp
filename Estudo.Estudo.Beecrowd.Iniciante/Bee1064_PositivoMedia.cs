using System;
using System.Globalization;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1064_PositivoMedia
    {
        public static void executar()
        {
         
            decimal[] valores = new decimal[6];
            int qntPositivos = 0;
            decimal mediaPositivos = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (valores[i] > 0)
                {
                    qntPositivos++;
                    mediaPositivos += valores[i];
                }

            }

            mediaPositivos = mediaPositivos / qntPositivos;
            Console.WriteLine($"{qntPositivos} valores positivos\n{Math.Round(mediaPositivos,1)}");
            
        }
    }
}
