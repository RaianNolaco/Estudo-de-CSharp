using System;
using System.Globalization;

namespace Estudo.CursoUdemy.RecapLogica.ExerciciosAulas
{
    public class ExercicioAulaEntradaDados
    {
        public static void exercicio()
        {

            Console.WriteLine("Ola!");
            Console.WriteLine("\nDigite seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos comodos tem sua casa?");
            int qntComodos = int.Parse(Console.ReadLine());

            Console.WriteLine("Defina um preço para sua residencia: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seus dados dessas forma nome,idade,sexo,numero,email, UF do seu estado(Raian 20 M 900000000 raian@gmail.com SP)");
            string[] dados = Console.ReadLine().Split(' ');

            string nome = dados[0];
            int idade = int.Parse(dados[1]);
            char sexo = char.Parse(dados[2]);
            string numero = dados[3];
            string email = dados[4];
            var UF = dados[5];

            Console.WriteLine($"\nO proprietario {nomeCompleto}, está vendendo uma casa com {qntComodos} comodos por R${valor:F2}");
            Console.WriteLine($"\nDados do vendedor:\nNome: {nome}\nIdade: {idade}\nSexo: {sexo}\nNumeor: {numero}\nE-mail: {email}\nEstado: {UF}");



        }
    }
}