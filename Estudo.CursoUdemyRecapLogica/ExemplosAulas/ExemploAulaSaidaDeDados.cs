using System;

namespace Estudo.CursoUdemy.RecapLogica.Classes
{
    public class ExemploAulaSaidaDados
    {

        public static void exemplo()
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //placeHolder
            Console.WriteLine("Placeholder: {0} tem {1} anos e tem {2:F2} reais na conta", nome, idade, saldo);

            //interpolação
            Console.WriteLine($"interpolação: {nome} tem {idade} anos e tem {saldo:F2} reais na conta");

            //concatenação
            Console.WriteLine("interpolação: " + nome + " tem " + idade + " anos e tem " + saldo.ToString("F2") + " reais na conta");
        }

    }
}