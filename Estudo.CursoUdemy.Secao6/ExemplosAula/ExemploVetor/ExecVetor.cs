using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.AulasExemplos.ExemploVetor
{
    class ExecVetor
    {
        public static void executar()
        {
            Console.WriteLine("Quantos numeor deseja em seu vetor de idades?");
            int qnt = int.Parse(Console.ReadLine());

            double soma = 0;
            double[] alturas = new double[qnt];

            for (int i = 0; i < qnt; i++)
            {
                Console.WriteLine($"Digite á {i + 1}° altura");
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                soma += alturas[i];
            }

            double media = soma / alturas.Length;
            Console.WriteLine($"Media de altura: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}