using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao7.ExemploAula.ExemploDateTime
{
    class ExecDateTime
    {
        public static void Executar()
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
        }
    }
}
