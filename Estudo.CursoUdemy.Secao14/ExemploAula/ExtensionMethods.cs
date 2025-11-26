using Estudo.CursoUdemy.Secao13.Extantisons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao14.ExemploAula
{
    public static class ExtensionMethods
    {
        public static void executar()
        {
            DateTime dt = new DateTime(2025, 11, 25, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());


            string si = "Good morging dear students!";
            Console.WriteLine(si.Cut(10));

        }
    }
}
