using Estudo.CursoUdemy.POO_2.AulasExemplos.ExemploProduto.Classe;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_2.AulasExemplos.ExemploProduto
{
    class ProdutoExecAula
    {
        public static void ProdutoAntigoo()
        {
            /* Produto p = new Produto();

             Console.WriteLine("Entre com os dados do prouto: ");

             Console.Write("Nome: ");
             p.Nome = Console.ReadLine();

             Console.Write("Preço: ");
             p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.Write("Quantidade: ");
             p.Quantidade = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Dados do produto: " + p);

             Console.Write("\nDigite a quantidade de produtos que deseja adicionar: ");
             p.AdicionarProduto(int.Parse(Console.ReadLine()));

             Console.WriteLine("Dados atualizados: " + p);

             Console.Write("\nDigite a quantidade de produtos que deseja remover: ");
             p.RemoverProduto(int.Parse(Console.ReadLine()));

             Console.WriteLine("Dados atualizados: " + p);
            */
        }

        public static void Aula51()
        {
            Console.WriteLine("Entre com os dados do prouto: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("\nDigite a quantidade de produtos que deseja adicionar: ");
            p.AdicionarProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("\nDigite a quantidade de produtos que deseja remover: ");
            p.RemoverProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + p);
        }

        public static void Aula52()
        {

            //Console.WriteLine("Entre com os dados do prouto: ");

            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();

            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Produto p = new Produto(nome, preco);

            //Console.WriteLine("Dados do produto: " + p);

            //Console.Write("\nDigite a quantidade de produtos que deseja adicionar: ");
            //p.AdicionarProduto(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Dados atualizados: " + p);

            //Console.Write("\nDigite a quantidade de produtos que deseja remover: ");
            //p.RemoverProduto(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Dados atualizados: " + p);
        }

        public static void Aula53()
        {
            //Produto p = new Produto()
            //{
            //    Nome = "Geladeira",
            //    Preco = 1500.00,
            //    Quantidade = 10
            //};

            //Console.WriteLine("Dados do produto: " + p);

            //Console.Write("\nDigite a quantidade de produtos que deseja adicionar: ");
            //p.AdicionarProduto(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Dados atualizados: " + p);

            //Console.Write("\nDigite a quantidade de produtos que deseja remover: ");
            //p.RemoverProduto(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Dados atualizados: " + p);
        }

        public static void Aula55()
        {

            Produto p = new Produto("TV", 900, 10);

            // p.Quantidade = -10;
            // Console.WriteLine(p.Nome);
            string n = "T";

            Console.WriteLine(p.Nome);
            p.Nome = n;
            Console.WriteLine(p.Nome);
        }
    }
}
