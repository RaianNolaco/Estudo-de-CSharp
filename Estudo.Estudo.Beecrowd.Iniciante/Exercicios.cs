using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    class Exercicios
    {
        public static void bee1030_Lanche(){

            string[] listaNumero = Console.ReadLine().Split(' ');
            int n1 = int.Parse(listaNumero[0]);
            int n2 = int.Parse(listaNumero[1]);

            double pagar;
            switch (n1)
            {
                case 1:
                    pagar = 4.00 * n2;
                    break;
                case 2:
                    pagar = 4.50 * n2;
                    break;
                case 3:
                    pagar = 5.00 * n2;
                    break;
                case 4:
                    pagar = 2.00 * n2;
                    break;
                case 5:
                    pagar = 1.00 * n2;
                    break;
                default:
                    pagar = 0;
                    break;

            }

            Console.WriteLine("Total: R$ " +pagar.ToString("F2"));

            Console.WriteLine($"Total: R$ {pagar:F2}");

        }
    
        public static void bee160_Positivo()
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

        public static void bee1020_IdadeEmDias()
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

        public static void bee1067_Impares()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void bee1013_ehMaior()
        {
        
            string[] numeros = Console.ReadLine().Split(' ');
            int[] numerosInt = Array.ConvertAll(numeros, int.Parse);

            int maiorUm = (numerosInt[0] + numerosInt[1] + (numerosInt[0] - numerosInt[1])) / 2;
            int maiorDois = (maiorUm + numerosInt[2] + (maiorUm - numerosInt[2])) / 2;

            Console.WriteLine(maiorDois);


        }
    }
}
