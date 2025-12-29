using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.ExemploAula.AulaFunc
{
    public static class AulaFunc
    {
        public static void executar()
        {
            List<ProdutoFunc> produtosList = new List<ProdutoFunc>();
            produtosList.Add(new ProdutoFunc("TV", 900.00, 12));
            produtosList.Add(new ProdutoFunc("Mouse", 50.00, 4));
            produtosList.Add(new ProdutoFunc("Tablet", 350.00, 2));
            produtosList.Add(new ProdutoFunc("HD Case", 80.90, 6));



            Func<ProdutoFunc, string> NomesUpper = UpperNome;
            var listNomesUpper = produtosList.Select(NomesUpper).ToList();
            listNomesUpper.ForEach(Console.WriteLine);

            Console.WriteLine("===========================");

            Func<ProdutoFunc, string> listNomesUpperLambdaDelegate = p => p.Nome.ToUpper();
            var listNomesUpper2 = produtosList.Select(NomesUpper).ToList();
            listNomesUpper.ForEach(Console.WriteLine);

            Console.WriteLine("===========================");

            var listNomesUpperLambda = produtosList.Select(p => p.Nome.ToUpper()).ToList();
            listNomesUpperLambda.ForEach(Console.WriteLine);

            Console.WriteLine("===========================");

        }

        public static string UpperNome(ProdutoFunc p)
        {
            return p.Nome.ToUpper();
        }
    }
}
