using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploForeach
{
    class ExecForeach
    {
        public static void Execultar()
        {
            string[] vect = new string[] { "Viper", "Chamber", "Raze" };

            foreach (string i in vect)
            {
                Console.WriteLine(i);
            }
        }
    }
}
