using System;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1013_EhMaior
    {
        public static void executar()
        {

            string[] numeros = Console.ReadLine().Split(' ');
            int[] numerosInt = Array.ConvertAll(numeros, int.Parse);

            int maiorUm = (numerosInt[0] + numerosInt[1] + (numerosInt[0] - numerosInt[1])) / 2;
            int maiorDois = (maiorUm + numerosInt[2] + (maiorUm - numerosInt[2])) / 2;

            Console.WriteLine(maiorDois);


        }
    }
}
