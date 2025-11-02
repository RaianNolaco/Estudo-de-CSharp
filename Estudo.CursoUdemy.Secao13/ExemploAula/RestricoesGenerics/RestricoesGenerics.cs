using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao13.ExemploAula.RestricoesGenerics
{
    public static class RestricoesGenerics
    {
        public static void executar()
        {
            List<int> lista = new List<int>();

            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                lista.Add(x);
            }

            CalculationService calculationService = new CalculationService();

            int max = calculationService.Max(lista);

            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
    }
}
