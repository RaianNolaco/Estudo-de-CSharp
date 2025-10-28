using System;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploRefOut_
{
    class ExecOutRef
    {
     
        public static void Executar()
        {
            Console.WriteLine("Exemplo errado: ");
            int n1 = 10;
            CalcNaoFunciona.Triple(n1);
            Console.WriteLine(n1);

            Console.WriteLine("\nExemplo Com uso de ref: ");
            int n2 = 10;
            CalcRef.Triple(ref n2);
            Console.WriteLine(n2);


            Console.WriteLine("\nExemplo com uso de out ref");
            int n3 = 10;
            int calc;
            CalcOut.Triple(n3,out calc);
            Console.WriteLine(calc);

            Console.WriteLine("O USO DO OUT E REF SÃO CONSIDERADOS CODIGO RUIM, ENTÂO DEVEMOS EVITAR DE USALOS");
        }
        
    }
}
