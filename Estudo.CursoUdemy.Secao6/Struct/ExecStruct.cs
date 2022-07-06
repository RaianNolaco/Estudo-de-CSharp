using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.Struct
{
    class ExecStruct
    {
        public static void exemplo()
        {
            Point p;

            p.X = 10;
            p.Y = 30;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);
        }
    }
}
