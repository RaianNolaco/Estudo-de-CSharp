using System;
using System.Collections.Generic;

namespace Estudo.CursoUdemy.RecapLogica.ExerciciosAulas.ExerciciosPropostos
{
    public class ExerciciosLacoWhile
    {
        public static void senha()
        {
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