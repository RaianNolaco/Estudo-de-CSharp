using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1060_Positivo
    {
        public static void executar()
        {
            int positivos = 0;

            for (int i = 1; i <= 6; i++)
            {
                double a = double.Parse(Console.ReadLine());

                if (a > 0)
                {
                    positivos++;
                }
            }

            Console.WriteLine(positivos + " valores positivos");

        }
    }
}
