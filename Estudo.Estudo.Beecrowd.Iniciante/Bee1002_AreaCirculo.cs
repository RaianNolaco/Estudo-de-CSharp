using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1002_AreaCirculo
    {
        public static void executar()
        {
            double raio = Convert.ToDouble(Console.ReadLine());
            double n = 3.14159;
            double area = n * (raio * raio);

            Console.WriteLine("A=" + String.Format("{0:0.0000}", area));
        }
    }
}
