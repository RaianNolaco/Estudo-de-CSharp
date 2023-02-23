using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1020_IdadeEmDias
    {
        public static void executar()
        {
            int idade = int.Parse(Console.ReadLine());

            int qntAnos = 0;
            int qntMeses = 0;

            while (idade >= 365)
            {
                idade -= 365;
                qntAnos++;
            }
            while (idade >= 30)
            {
                idade -= 30;
                qntMeses++;
            }

            Console.WriteLine($"{qntAnos} ano (s)\n{qntMeses} mes (es)\n{idade} dia (s)");
        }
    }
}
