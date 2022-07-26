using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao7.ExemploAula.ExemploSwitchCase
{
    internal class ExecSwitchCase
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um numero de 0 a 10");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 0:
                    Console.WriteLine("Numero é Zero");
                    break;
                case 2:
                    Console.WriteLine("Numero é Dois");
                    break;
                case 10:
                    Console.WriteLine("Numero é Dez");
                    break;
                default:
                    Console.WriteLine("numero não é zero nem dois");
                    break;
            }
        }
    }
}
