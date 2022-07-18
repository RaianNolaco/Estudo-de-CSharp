using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploRefOut_
{
    class CalcRef
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}
