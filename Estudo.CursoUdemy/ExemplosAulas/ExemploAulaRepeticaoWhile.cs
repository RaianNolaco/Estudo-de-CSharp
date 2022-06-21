using System;
using System.Globalization;

namespace Estudo.CursoUdemy.RecapLogica.ExemplosAulas
{
    public class ExemploAulaRepeticaoWhile
    {
        public static void exemplo()
        {
            Console.WriteLine("Digite um numeor ");
            int numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite um numeor ");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numero negativo");

        }
    }
}