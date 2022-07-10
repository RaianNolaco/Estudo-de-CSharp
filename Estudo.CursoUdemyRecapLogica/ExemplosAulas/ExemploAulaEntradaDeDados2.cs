
using System;
using System.Globalization;

namespace Estudo.CursoUdemy.RecapLogica.ExemplosAulas
{
    public class ExemploAulaEntradaDeDados2
    {
        public static void exemplo()
        {

            Console.WriteLine("Digite um numero interio: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero interio: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um caractere: ");
            char c1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero decimal: ");
            double d1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero decimal: ");
            double d2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite separadamente, seu nome,sexo(F/M),idade, e altura ex: (Maria F 23 1.68): ");
            string[] dados = Console.ReadLine().Split(' ');
            string nome = dados[0];
            char sexo = char.Parse(dados[1]);
            int idade = int.Parse(dados[2]);
            double altura = double.Parse(dados[3], CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntando com tipos diferentes: ");

            Console.WriteLine($"\nValor int 1: {n1}\nValor int 2: {n2}");
            Console.WriteLine("Valor char: " + c1);
            Console.WriteLine("Valor double SEM formatação cultureInfo: " + d1);
            Console.WriteLine("Valor double COM formatação cultureInfo: " + d2.ToString(CultureInfo.InvariantCulture));



            Console.WriteLine("\nSeus dados: ");
            Console.WriteLine($"Seu Nome é: {dados[0]}\nSeu Sexo: {dados[1]}\nSua Idade: {dados[2]}\nVocê mede: {dados[3]}");


            Console.WriteLine("\nSeus dados: ");
            Console.WriteLine($"Seu Nome é: {nome}\nSeu Sexo: {sexo}\nSua Idade: {idade}\nVocê mede: {altura}");

        }
    }
}