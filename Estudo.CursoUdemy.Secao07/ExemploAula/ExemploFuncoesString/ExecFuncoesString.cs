using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao7.ExemploAula.ExemploFuncoesString
{
    internal class ExecFuncoesString
    {
        public static void Executar()
        {
            string original = "  TESTE Teste teste BOM DIA  bom dia  HELLO WORLD  helo world TESTE Teste teste";

            string upper = original.ToUpper();
            string lower = original.ToLower();
            string trim = original.Trim();

            int procurar1 = original.IndexOf("este");
            int procurar2 = original.LastIndexOf("este");

            string substring = original.Substring(50);
            string substring2 = original.Substring(50,5);

            string replace = original.Replace('e','&');
            string replace2 = original.Replace("teste","EiTa");

            bool nulo = string.IsNullOrEmpty(original);
            bool nolo2 = string.IsNullOrWhiteSpace(original);


            Console.WriteLine(original);
            Console.WriteLine(upper);
            Console.WriteLine(lower);
            Console.WriteLine(trim);
            Console.WriteLine(procurar1);
            Console.WriteLine(procurar2);
            Console.WriteLine(substring);
            Console.WriteLine(substring2);
            Console.WriteLine(replace);
            Console.WriteLine(replace2);


        }
    }
}
