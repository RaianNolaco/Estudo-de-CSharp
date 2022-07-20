using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploList
{
    class ExecList
    {
        public static void Execultar()
        {
            List<string> list = new List<string>();

            List<string> nomes = new List<string> {"Chamber","Reyna","Kay/o"};

            foreach (string agentes in nomes )
            {
                Console.WriteLine(agentes);
            }
            Console.WriteLine(nomes[0]);

            Console.WriteLine("\n");

            ListFuncoes.Manipulandodados();
        }
    }
}
