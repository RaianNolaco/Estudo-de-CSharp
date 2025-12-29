using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.ExemploAula.LinqAula
{
    public static class LinqAula
    {
        public static void executar(){
            
            //Especificar fonte de dados
            int[] numeros = new int[] { 2, 3, 4, 5 };

            //Definir a expressão da query


            //var resultFluent_1 = numeros.Where(x => x <= 3);

            var resultSQL_1 = from numero in numeros
                              where numero <= 3
                              select numero;

            var resultFluent_2 = numeros
                .Where(a => a % 2 != 0 )
                .Select(a => a * 5);

            //var resultSQL_2 = from numero in numeros
            //                where numero % 2 != 0
            //                select numero * 5;


            //Executar a query

            Console.WriteLine("====================================");
            resultSQL_1.ToList().ForEach(Console.WriteLine);

            Console.WriteLine("====================================");
            resultFluent_2.ToList().ForEach(Console.WriteLine);

            List<string> nomes = new List<string> { "Ana", "Bruno", "Carlos", "Daniela" };

            // Consulta LINQ para encontrar nomes que começam com 'C'
            var nomesComC = from nome in nomes
                            where nome.StartsWith("C")
                            select nome;

            // Ou usando sintaxe fluente (métodos de extensão):
            var nomesComC_Fluent = nomes.Where(nome => nome.StartsWith("C"));

            // Iterando sobre os resultados (a consulta é executada aqui)
            Console.WriteLine("====================================");
            foreach (var nome in nomesComC)
            {
                Console.WriteLine(nome); // Saída: Carlos, Daniela
            }

        }
    }
}
