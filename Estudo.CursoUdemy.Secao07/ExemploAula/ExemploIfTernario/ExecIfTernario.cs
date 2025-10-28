using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao7.ExemploAula.ExemploIfTernario
{
    internal class ExecIfTernario
    {
        public static void Executar()
        {
            Console.WriteLine("Você é homen ou mulher? 1 - Homen/2 - Mulher");
            int x = int.Parse(Console.ReadLine());

            string sexo = (x == 1) ? "Homen" : "Mulher";

            Console.WriteLine("Quantos anos vc tem?");
            
            int idade = int.Parse(Console.ReadLine());
            string deMaior = (idade >= 18) ? "maior de idade" :"menor de idade";

            Console.WriteLine(sexo +", "+ deMaior);
        }
    }
}
