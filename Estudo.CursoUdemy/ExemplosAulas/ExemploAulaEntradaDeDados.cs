using System;

namespace Estudo.CursoUdemy.RecapLogica.ExemplosAulas
{
    public class ExemploAulaEntradaDeDados
    {
        public static void exemplo()
        {
            string frase = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            Console.WriteLine("\nVocê digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // usando o Split para separar variaveis
            string s = Console.ReadLine();
            string[] vet = s.Split();

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("os valores da lista são: ");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(vet[0]);



        }
    }
}