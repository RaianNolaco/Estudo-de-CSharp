using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.ExemploAula.PredicateAula
{
    public static class PredicateAula
    {
        public static void executar()
        {
            List<Produto> produtosList = new List<Produto>();

            produtosList.Add(new Produto("TV",900.00,12));
            produtosList.Add(new Produto("Mouse",50.00,4));
            produtosList.Add(new Produto("Tablet", 350.00,2));
            produtosList.Add(new Produto("HD Case",80.45,6));

            
            produtosList.ForEach(Console.WriteLine); // => Action

            var listPoucosProdutos = produtosList.Where(ProdutosComQuantidadeBaixa);

            Console.WriteLine("\n------------Produtos com baixo estoque---------------");
            listPoucosProdutos.ToList().ForEach(Console.WriteLine);

            Console.WriteLine("\n-----------Produtos com preço abaixo de 100---------------");
            //produtosList.RemoveAll(x => x.Preco >= 100);// => Predicate
            produtosList.RemoveAll(validaPreco);// => Predicate
            produtosList.ForEach(Console.WriteLine); // => Action

        }


        public static bool validaPreco(Produto p)
        {
            return p.Preco >= 100;
        }

        public static bool ProdutosComQuantidadeBaixa(Produto p)
        {
            return p.Quantidade <= 10;
        }
    }
}
