using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1030_Lanche
    {
        public static void executar()
        {

            string[] listaNumero = Console.ReadLine().Split(' ');
            int n1 = int.Parse(listaNumero[0]);
            int n2 = int.Parse(listaNumero[1]);

            double pagar;
            switch (n1)
            {
                case 1:
                    pagar = 4.00 * n2;
                    break;
                case 2:
                    pagar = 4.50 * n2;
                    break;
                case 3:
                    pagar = 5.00 * n2;
                    break;
                case 4:
                    pagar = 2.00 * n2;
                    break;
                case 5:
                    pagar = 1.00 * n2;
                    break;
                default:
                    pagar = 0;
                    break;

            }

            Console.WriteLine("Total: R$ " + pagar.ToString("F2"));

            Console.WriteLine($"Total: R$ {pagar:F2}");

        }
    }
}
