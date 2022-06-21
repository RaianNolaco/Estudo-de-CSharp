using System;

namespace Estudo.CursoUdemy.RecapLogica.ExemplosAulas
{
    class ExemploAulaFuncoes
    {
        public static void exemplo()
        {
            Console.WriteLine("digite tes numeors: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

        }

        public static int Maior(int n1, int n2, int n3)
        {
            int maior;
            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n3)
            {
                maior = 2;
            }
            else
            {
                maior = n3;
            }

            return maior;
        }
    }
}