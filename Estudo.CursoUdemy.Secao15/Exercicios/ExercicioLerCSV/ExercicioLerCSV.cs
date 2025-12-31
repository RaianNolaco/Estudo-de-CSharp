using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.Exercicios.ExercicioLerCSV
{
    public static class ExercicioLerCSV
    {
        public static void executar()
        {
            Console.Write("Insira a pasta do arquivo csv: ");
            string path = Console.ReadLine();

            List<ProdutoCSV> lista = new List<ProdutoCSV>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    var values = line.Split(',');

                    lista.Add(new ProdutoCSV
                    {
                        Nome = values[0],
                        Preco = Convert.ToDouble(values[1], CultureInfo.InvariantCulture)
                    });
                }
            }


            var media = lista
                .Select(x => x.Preco)
                .DefaultIfEmpty(0.0)
                .Average();
            Console.WriteLine("Media de preço: " + Math.Round(media,2));

            var produtosAbaixo = lista
                .Where(x => x.Preco < media)
                .OrderByDescending(x => x.Nome)
                .Select(x => x.Nome);

            Console.WriteLine("Produtos abaixo da media de preço");
            produtosAbaixo.ToList().ForEach(Console.WriteLine);
        }
    }
}
