using System;
using System.Collections.Generic;

namespace Estudo.CursoUdemy.RecapLogica.ExerciciosAulas.ExerciciosPropostos
{
    public class ExerciciosEstruturaCondicional
    {
        public static void negativoPositivo()
        {
            /*Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.*/

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
            /*Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar*/
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
            /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            ordem crescente ou decrescente*/
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
            /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/
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
            /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
            Seguir, calcule e mostre o valor da conta a pagar.
            
            1  |  Cachorro quente   |  R$ 4.00   
            2  |  X-salada          |  R$ 4.50
            3  |  X-bacon           |  R$ 5.00
            4  |  torrada simples   |  R$ 2.00
            5  |  refrigerante      |  R$ 1.50
            */
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
            /*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
            nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/
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
            /*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
            de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
            Se o ponto estiver na origem, escreva a mensagem “Origem”.
            Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a */

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
            /*Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
            Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.*/
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