using System;
using System.Globalization;

namespace Estudo.CursoUdemy.RecapLogica.ExerciciosAulas
{
    public class ExercicioAulaSaidaDados
    {
        public static void exercicio()
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2}\n");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero: {genero}\n");

            Console.WriteLine("Media com oito casas decimais: " + media);
            Console.WriteLine($"Arredondado (tres casas decimais) : {media:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {media.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}