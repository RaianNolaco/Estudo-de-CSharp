using System;
using System.Collections.Generic;

namespace Estudo.CursoUdemy.RecapLogica.ExerciciosAulas.ExerciciosPropostos
{
    public class ExerciciosLacoWhile
    {
        public static void senha()
        {
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
            incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/
            bool certo = true;
            while (certo)
            {
                Console.WriteLine("Digite uma senha: ");
                string senha = Console.ReadLine();
                if (senha == "2002")
                    certo = false;
                else
                    Console.WriteLine("Senha incorreta");
            }

            Console.WriteLine("Acesso permitido");
        }

        public static void quadranteqWhile()
        {
            /*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/
            bool sair = true;
            while (sair)
            {
                List<int> xy = Utilitarios.pedirDoisNumerosInteiros();
                int x = xy[0];
                int y = xy[1];

                if (!(x == 0 || y == 0))
                {
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
                }
                else
                {
                    sair = false;
                }
            }
        }

        public static void postoDeGasolina()
        {
            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.*/
            bool sair = true;
            int alcool = 0;
            int gasolina = 0;
            int disel = 0;

            while (sair)
            {
                int n1 = Utilitarios.pedirNumeroInteiro("Vote em um dos nossos produtos: ");

                switch (n1)
                {
                    case 1:
                        alcool++;
                        break;

                    case 2:
                        gasolina++;
                        break;

                    case 3:
                        disel++;
                        break;

                    case 4:
                        Console.WriteLine("MUITO OBRIGADO");
                        sair = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }
            }
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Disel: " + disel);
        }
    }
}