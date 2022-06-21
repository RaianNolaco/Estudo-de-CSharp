using System;

namespace Estudo.CursoUdemy.RecapLogica.ExemplosAulas
{
    public class ExemploAulaEstruturaCondicional
    {
        public static void exemplo()
        {

            Console.WriteLine("Digite um numero interio: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine(n1 + " é par");
            }
            else
            {
                Console.WriteLine(n1 + " é impar");
            }


            Console.WriteLine("Que horario é agora ? digite (hora,minutos => 12,30)");
            double horario = double.Parse(Console.ReadLine());

            if (horario > 6 && horario < 12)
            {
                Console.WriteLine("Bom dia ");
            }
            else if (horario > 12 && horario < 19)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("boa noite");
            }

        }
    }
}