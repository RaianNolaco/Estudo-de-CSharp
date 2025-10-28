using Estudo.CursoUdemy.POO_1.AulasExemplos.ExemploProduto.Classe;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1.AulasExemplos.ExemploProduto
{
    class ProdutoAula
    {
        public static void pedirDadosproduto(Produto p)
        {
            Console.WriteLine("Entre com os dados do prouto: ");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());
        } 

        public static void produtoAula42()
        {
            Produto p = new Produto();

            pedirDadosproduto(p);

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("Valor em estoque: " + p.ValorTotalEmEstoque()) ;

        }

        public static void produtoAula43()
        {
            Produto p = new Produto();


            pedirDadosproduto(p);

            Console.WriteLine(p.ToString());
        }

        public static void produtoAula44()
        {
            Produto p = new Produto();

            pedirDadosproduto(p);

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("\nDigite a quantidade de produtos que deseja adicionar: ");
            p.AdicionarProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("\nDigite a quantidade de produtos que deseja remover: ");
            p.RemoverProduto(int.Parse(Console.ReadLine()));
            
            Console.WriteLine("Dados atualizados: " + p);

        }


    }
}
