using System;
using System.Collections.Generic;

namespace Estudo.CursoUdemy.RecapLogica.ExerciciosAulas.ExerciciosPropostos
{
    public class ExerciciosEstruturaCondicional
    {
        public static void negativoPositivo()
        {

            int n1 = Utilitarios.pedirNumeroInteiro();

            if (n1 > 0)
            {
                Console.WriteLine(n1 + " é positivo");
            }
            else if (n1 == 0)
            {
                Console.WriteLine(n1 + " é neutro");
            }
            else
            {
                Console.WriteLine(n1 + " é negativo");
            }

        }

        public static void parImpar()
        {
            int n1 = Utilitarios.pedirNumeroInteiro();

            if (n1 % 2 == 0)
            {
                Console.WriteLine(n1 + " é Par");
            }
            else
            {
                Console.WriteLine(n1 + " é impar");
            }
        }

        public static void multioplos()
        {
            List<int> valores = Utilitarios.pedirDoisNumerosInteiros();
            int n1 = valores[0];
            int n2 = valores[1];

            if ((n1 > n2 && n1 % n2 == 0) || (n1 < n2 && n2 % n1 == 0))
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("não são multiplos");
            }
        }

        public static void horasJogo()
        {
            List<int> valores = Utilitarios.pedirDoisNumerosInteiros();
            int hrInicial = valores[0];
            int hrFinal = valores[1];

            int calcHr;

            if (hrInicial < hrFinal)
            {
                calcHr = hrFinal - hrInicial;
            }
            else
            {
                calcHr = 24 - hrInicial + hrFinal;
            }

            Console.WriteLine("O JOGO DUROU " + calcHr + " HORA(S)");
        }

        public static void valorPagar()
        {
            List<int> valores = Utilitarios.pedirDoisNumerosInteiros();
            int n1 = valores[0];
            int n2 = valores[1];

            double pagar;
            if (n1 == 1)
            {
                pagar = 4.00 * n2;
            }
            else if (n1 == 2)
            {
                pagar = 4.50 * n2;
            }
            else if (n1 == 3)
            {
                pagar = 5.00 * n2;
            }
            else if (n1 == 4)
            {
                pagar = 2.00 * n2;
            }
            else if (n1 == 5)
            {
                pagar = 1.00 * n2;
            }
            else
            {
                Console.WriteLine("Este produto não existe");
                return;
            }

            Console.WriteLine($"Total: R${pagar:F2}");
        }

        public static void intervalo()
        {
            double n1 = Utilitarios.pedirNumeroDecimal();

            if (n1 >= 0 && n1 <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (n1 >= 25 && n1 <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (n1 >= 50 && n1 <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (n1 >= 75 && n1 <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }

        public static void quadrante()
        {
            List<double> valores = Utilitarios.pedirDoisNumerosDecimais();
            double x = valores[0];
            double y = valores[1];

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }

        public static void impostoDeRenda()
        {
            double n1 = Utilitarios.pedirNumeroDecimal("Digite seu salario: ");

            double imposto;
            if (n1 <= 2000.00)
            {
                imposto = 0.0;
            }
            else if (n1 <= 3000.00)
            {
                imposto = (n1 - 2000) * 0.08;
            }
            else if (n1 <= 4500.00)
            {
                imposto = (n1 - 3000) * 0.18 + 1000 * 0.08;
            }
            else
            {
                imposto = (n1 - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("insento");
                return;
            }

            Console.WriteLine($"R$ {imposto:F2}");

        }
    }
}