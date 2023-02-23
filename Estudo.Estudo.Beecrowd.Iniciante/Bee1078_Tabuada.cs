    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public class Bee1078_Tabuada
    {
        public static void executar()
        {

            int numero = Convert.ToInt32(Console.ReadLine());
            //tabuada(numero);

            tabuada_for(numero);

        }
        public static void tabuada(int n, int cont = 1)
        {
            Console.WriteLine($"{cont} x {n} = {cont * n}");
            cont++;


            if (cont <= 10)
                tabuada(n,cont);
        }

        public static void tabuada_for(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n} = {i * n}");
            }



        }
    }
}
