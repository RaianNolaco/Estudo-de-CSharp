using System;

namespace Estudo.CursoUdemy.RecapLogica.ExemplosAulas
{
    public class ExemploAulaOperadoresLogicos
    {
        public static void exemplo()
        {
            bool c1 = 2 > 3 || 4 != 5;
            Console.WriteLine(c1);// true

            bool c2 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c2);// true

            bool c3 = c1 == true || 1 < 0;
            Console.WriteLine(c3); // true

            bool c4 = !(c1 == c3);
            Console.WriteLine(c4); //false

            bool c5 = !c3 != c1;
            Console.WriteLine(c5); // true

            bool c6 = c1 != c2 || !c3 == c5 && c2 != c4;
            Console.WriteLine(c6);// false


            Console.ReadLine();
        }
    }
}