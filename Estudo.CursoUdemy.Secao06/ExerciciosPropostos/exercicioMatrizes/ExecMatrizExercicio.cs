using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExerciciosPropostos.exercicioMatrizes
{
    class ExecMatrizExercicio
    {
        public static void Executar()
        {
            Console.Write("Digite a ordem X da sua matriz: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite a ordem Y da sua matriz: ");
            int y = int.Parse(Console.ReadLine());

            int[,] mat = new int[x, y];

            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"Digite os valores da {i}° linha");
                string[] linha = Console.ReadLine().Split(' ');
                for (int i2 = 0; i2 < y; i2++)
                {
                    mat[i, i2] = int.Parse(linha[i2]);
                }
            }

            Console.WriteLine("\n");

            for (int i = 0; i < x; i++)
            {
                for (int i2 = 0; i2 < y; i2++)
                {
                    Console.Write(mat[i, i2] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Digite um numero da matriz: ");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mat[i, j] == n1)
                    {
                        Console.WriteLine($"-----------\n" +
                                          $"Posição: {i},{j}");
                        if (i > 0)
                        {
                            Console.WriteLine("Cima: " + mat[i - 1, j]);
                        }
                        if (i < x - 1)
                        {
                            Console.WriteLine("Baixo: " + mat[i + 1, j]);

                        }
                        if (j < y - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                    }
                }
            }
        }
    }
}
