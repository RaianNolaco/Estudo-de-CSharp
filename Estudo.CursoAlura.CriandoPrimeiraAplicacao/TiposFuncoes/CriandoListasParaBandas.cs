using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoAlura.CriandoPrimeiraAplicacao.TiposFuncoes
{
    public class CriandoListasParaBandas
    {
        static string mensagemDeBoasVindas = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";

        public static void Excutar()
        {
            ExibirMensagemDeBoasVindas();
            ExibirOpcoesDoMenu();
        }

        static void ExibirMensagemDeBoasVindas()
        {
            Console.WriteLine(mensagemDeBoasVindas);
        }

        static void ExibirOpcoesDoMenu()
        {
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");

            //A ! diz que a resposta de readline pode vir nula
            string opcaoEscolhida = Console.ReadLine()!;

            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case 4:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case -1:
                    Console.WriteLine("Tchau tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
