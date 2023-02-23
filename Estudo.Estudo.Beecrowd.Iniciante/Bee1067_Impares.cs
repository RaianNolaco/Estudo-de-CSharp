using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1067_Impares
    {
        public static void executar()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
