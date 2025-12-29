using Estudo.CursoUdemy.Secao15.ExemploAula.PredicateAula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.ExemploAula.ActionAula
{
    public class ActionAula
    {
        public static void executar() {
           
            List<ProdutoAction> produtosList = new List<ProdutoAction>();

            produtosList.Add(new ProdutoAction("TV", 900.00, 12));
            produtosList.Add(new ProdutoAction("Mouse", 50.00, 4));
            produtosList.Add(new ProdutoAction("Tablet", 350.00, 2));
            produtosList.Add(new ProdutoAction("HD Case", 80.90, 6));

            Action<ProdutoAction> act = AtualizarPreco;
            Action<ProdutoAction> actLamda = p => { p.Preco += p.Preco * 0.1; };

            produtosList.ForEach(Console.WriteLine);
            Console.WriteLine("===========================");

            produtosList.ForEach(AtualizarPreco);
            produtosList.ForEach(Console.WriteLine);
            Console.WriteLine("===========================");

            produtosList.ForEach(act);
            produtosList.ForEach(Console.WriteLine);
            Console.WriteLine("===========================");

            produtosList.ForEach(actLamda);
            produtosList.ForEach(Console.WriteLine);
            Console.WriteLine("===========================");

            produtosList.ForEach(p => p.Preco += p.Preco * 0.1);
            produtosList.ForEach(Console.WriteLine);
            produtosList.ForEach(AtualizarPreco);
        }


        static void AtualizarPreco(ProdutoAction p)
        {
           p.Preco += p.Preco * 0.1;
        }
    }
}
