using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao13.ExercicioProposto
{
    public static class ExercicioPropostoConjuntos
    {
        public static void executar()
        {
            var listaCursoA = perguntaAlunos("A");
            var listaCursoB = perguntaAlunos("B");
            var listaCursoC = perguntaAlunos("C");

            var listAB = listaCursoA.Union(listaCursoB);
            var listABC= listAB.Union(listaCursoC);
            var qntTotal = listABC.Count();

            Console.WriteLine("Total students: " + qntTotal);
        }


        public static List<int> perguntaAlunos(string curso)
        {
            Console.Write($"How many students for Curse {curso}?");
            var qntAlunos = int.Parse(Console.ReadLine());

            var listaAlunos = new List<int>();
            for (int i = 0; i < qntAlunos; i++) {
                var idAluno = int.Parse(Console.ReadLine());
                listaAlunos.Add(idAluno); 
            }

            return listaAlunos;
        }
    }
}
