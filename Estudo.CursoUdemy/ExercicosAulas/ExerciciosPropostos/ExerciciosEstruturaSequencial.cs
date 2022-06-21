using System;
using System.Globalization;

namespace Estudo.CursoUdemy.RecapLogica.ExerciciosAulas.ExerciciosPropostos
{
    public class ExerciciosEstruturaSequencial
    {
        public static void soma()
        {
            /**/

            Console.WriteLine("Digite um Numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            double n2 = double.Parse(Console.ReadLine());

            double soma = n1 + n2;

            Console.WriteLine($"{n1} + {n2} = {soma}");

        }

        public static void AreaCirculo()
        {
            /**/
            Console.WriteLine("Digite o valor de um raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = double.Parse(Math.PI.ToString("F5")) * Math.Pow(raio, 2);

            Console.WriteLine($"Valor da area é {area.ToString("F4", CultureInfo.InvariantCulture)}");

        }

        public static void DiferencaProduto()
        {
            /**/
            Console.WriteLine("Digite 4 valores separados por espaços ex:( 1 4 2 6 ): ");
            string[] valores = Console.ReadLine().Split(' ');

            int AB = int.Parse(valores[0]) * int.Parse(valores[1]);
            int CD = int.Parse(valores[2]) * int.Parse(valores[3]);
            int calc = AB - CD;

            Console.WriteLine("A diferença é :" + calc);
        }

        public static void salario()
        {
            /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
            decimais.*/

            Console.WriteLine("Digite o seu numero de registro, horas trabalhadas e salaraio/hora(em uma linha separado por espaços)");
            string[] valores = Console.ReadLine().Split(' ');

            double salario = double.Parse(valores[1], CultureInfo.InvariantCulture) * double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionario de numero {valores[0]} receberá U${salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void valorPecas()
        {
            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/

            Console.Write("Digite em uma linha o codigo da 1° peça a quantidade eo valor: ");
            string[] peca1 = Console.ReadLine().Split(' ');

            double calcPeca1 = double.Parse(peca1[1], CultureInfo.InvariantCulture) * double.Parse(peca1[2], CultureInfo.InvariantCulture);

            Console.Write("Digite em uma linha o codigo da 1° peça a quantidade eo valor: ");
            string[] peca2 = Console.ReadLine().Split(' ');

            double calcPeca2 = double.Parse(peca2[1], CultureInfo.InvariantCulture) * double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double total = calcPeca1 + calcPeca2;

            Console.WriteLine($"\nO Valor toatal a pagar pelas peças é de R${total:F2}");
        }

        public static void area()
        {
            /*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.*/

            string[] valoresPegos = new string[3];

            Console.WriteLine("Digite os valores de A, B e C (na mesma linha): ");
            valoresPegos = Console.ReadLine().Split(' ');

            double[] valores = new double[3];
            int teste = valoresPegos.Length;
            for (int i = 0; i < valoresPegos.Length; i++)
            {
                valores[i] = double.Parse(valoresPegos[i], CultureInfo.InvariantCulture);
            }

            double areaTriangulo = valores[0] * valores[2] / 2;
            double areaCirculo = double.Parse(Math.PI.ToString("F5")) * Math.Pow(valores[2], 2);
            double areaTrapezio = (valores[0] + valores[1]) * valores[2] / 2;
            double areaQuadrado = Math.Pow(valores[1], 2);
            double areaRetangulo = valores[0] * valores[1];

            Console.WriteLine($"Tringulo: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");


        }
    }
}