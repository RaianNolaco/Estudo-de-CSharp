using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploMatrizes
{
    class ExercicioMatriz
    {
        public static void ExercicioAula()
        {
            Console.Write("Digite a ordem de sua matriz: ");
            int ordem = int.Parse(Console.ReadLine());

            int[,] mat = new int[ordem, ordem];

            List<int> diagonal = new List<int>();
            int negativos = 0;

            for (int i = 0; i < ordem; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int i2 = 0; i2 < ordem; i2++)
                {
                    int n = int.Parse(linha[i2]);
                    mat[i, i2] = n;

                    if(i == i2)
                    {
                        diagonal.Add(n);
                    }

                    if(n < 0)
                    {
                        negativos++;
                    }
                }
            }

            Console.WriteLine("\nMain diagonal:");
            foreach (var item in diagonal)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nNegative numbers = " + negativos);
        }
    }
}
