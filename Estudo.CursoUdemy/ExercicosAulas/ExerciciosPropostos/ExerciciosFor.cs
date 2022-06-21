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
            int n1 = Utilitarios.pedirNumeroInteiro();

            for (int i = 1; i <= n1; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}");
            }
        }
    }
}
