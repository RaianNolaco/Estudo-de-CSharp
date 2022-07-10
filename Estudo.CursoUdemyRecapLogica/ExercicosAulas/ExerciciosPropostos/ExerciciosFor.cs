using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.RecapLogica.ExercicosAulas.ExerciciosPropostos
{
    public class ExerciciosFor
    {
        public static void impares()
        {
            /*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            X, se for o caso.*/
            int n1 = Utilitarios.pedirNumeroInteiro("Digite um numero inteiro maio q 0 e menos que 1000: ");

            for (int i = 1; i<=n1; i++)
            {
                if (!(i%2==0))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void intervalo()
        {
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)*/
            int n1 = Utilitarios.pedirNumeroInteiro("Quantos valores deseja incluir? ");

            int dentro = 0;
            int fora = 0;
            for(int i = 1; i <= n1; i++)
            {
                int num = Utilitarios.pedirNumeroInteiro($"Digite o {i}° numero: ");
                if (num >= 10 && num <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine($"{dentro} in\n{fora} out");
        }

        public static void testes()
        {
            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.*/
            int qntTestes = Utilitarios.pedirNumeroInteiro("Digite a quantidade de testes para processar: ");

            List<double> medias = new List<double>();
            for (int i = 1; i <= qntTestes; i++)
            {
                List<double> notas = Utilitarios.pedirNumerosDecimais(3,"Digite 3 notas na mesma linha: ");

                double calc = (notas[0] * 2 + notas[1] * 3 + notas[2] * 5) / (2 + 3 + 5);
                medias.Add(calc);
            }

            foreach (var item in medias)
            {
                Console.WriteLine(item.ToString("F1", CultureInfo.InvariantCulture));
            }

        }

        public static void divisao()
        {
            /*Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".*/
            int qntDivisoes = Utilitarios.pedirNumeroInteiro("Quantas divisões você quer fazer? ");

            for (int i = 1; i <= qntDivisoes; i++)
            {
                List<double> conta = Utilitarios.pedirNumerosDecimais(2, "Digite dois numeros na mesma linha: ");
                if (conta[1] == 0){
                    Console.WriteLine("Divisão imposivel");
                }
                else
                {
                    double calc = conta[0] / conta[1];
                    Console.WriteLine(calc);
                }
            }
        }

        public static void fatorial()
        {
            /*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            Lembrando que, por definição, fatorial de 0 é 1.*/
            int n1 = Utilitarios.pedirNumeroInteiro("Digigite um numero para calcular seu fatorial: ");

            int calc = 1;
            for (int i = 1; i <= n1; i++)
            {
                calc *= i;
            }
            Console.WriteLine(calc);
        }

        public static void divisores()
        {
            /*Ler um número inteiro N e calcular todos os seus divisores.*/
            int n1 = Utilitarios.pedirNumeroInteiro();

            for (int i = 1; i <= n1;i++)
            {
                if (n1%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void quadradoECubo()
        {
            /*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            exemplo.*/
            int n1 = Utilitarios.pedirNumeroInteiro();

            for (int i = 1; i <= n1; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}");
            }
        }
    }
}
