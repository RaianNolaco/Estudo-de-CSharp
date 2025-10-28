using Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploParms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploParams
{
    class ExecParams
    {
        public static void Executar()
        {
            double soma1 = CalcErrada.Soma(3,2,5);
            double soma2 = CalcSemParams.Soma(new double[]{ 3, 2, 5 });
            double soma3 = CalcCerta.Soma(3, 2, 5);

            Console.WriteLine($"Soma com sobre carga de metodo: {soma1}");
            Console.WriteLine($"Soma com vetor de numero(Sem params): {soma2}");
            Console.WriteLine($"Soma com vetor com params: {soma3}");
        }
    }
}
