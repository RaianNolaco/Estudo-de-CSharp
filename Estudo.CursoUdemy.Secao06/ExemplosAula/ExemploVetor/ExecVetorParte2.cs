using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploVetor
{
    public class ExecVetorParte2
    {
        public static void produtos()
        {
            Console.Write("Digite a quantidade de itens: ");
            int qnt = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[qnt];
            double soma = 0;
 
            for (int i = 0; i < qnt; i++)
            {
                Console.Write("Nome:");
                string nome = Console.ReadLine();

                Console.Write("Digite o preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produtos[i] = new Produto { Nome = nome, Preco = preco};

                soma += produtos[i].Preco;
            }

            double media = soma / qnt;

            Console.WriteLine($"Media de preços é R${media:F2}");

        }
    }
}
