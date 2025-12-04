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
            DateTime dt = new DateTime(2025, 11, 11, 2, 30, 40);
            Console.WriteLine(dt.ElapsedTime());


            string si = "Good morging dear students!";
            Console.WriteLine(si.Cut(10));

        }
    }
}
