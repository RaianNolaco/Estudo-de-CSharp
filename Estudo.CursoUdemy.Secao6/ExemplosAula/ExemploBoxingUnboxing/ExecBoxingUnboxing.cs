using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploBoxingUnboxing
{
    class ExecBoxingUnboxing
    {
        public static void Execultar()
        {
            int x = 10;
            Console.WriteLine(x);

            //boxing 
            object obj = x;
            Console.WriteLine(obj);

            //Unboxing
            int y = (int)obj;
            Console.WriteLine(y);
        }

    }
}
