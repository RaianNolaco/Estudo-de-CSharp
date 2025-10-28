using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExerciciosPropostos.ExerciciosVetores
{
    class ExecHotel
    {
        public static void Executar()
        {
            Console.Write("\nDigite a quantidade de quartos que irão ser reservcados: ");
            int qnt = int.Parse(Console.ReadLine());

            Quartos[] hospedes = new Quartos[10];

            for (int i = 1; i <= qnt; i++)
            {
                Console.Write($"\nDigite o nome do {i}° Hospede: ");
                string nome = Console.ReadLine();

                Console.Write($"Digite o e-mail do {i}° Hospede: ");
                string email = Console.ReadLine();

                int quarto = 0;
                bool sair = false;
                while (!sair)
                {
                    Console.Write("Digite o numero do quarto desejado: ");
                     quarto = int.Parse(Console.ReadLine());
                    
                    if(quarto >= 0 && quarto <= 9)
                    {
                        sair = true;
                        break;
                    }

                    Console.WriteLine("Digite apenas numeros de 0 a 9");
                }
           
                hospedes[quarto] = new Quartos { HospedeNome = nome, HospedeEmail = email, NumeroQuarto = quarto };
            }

            foreach (var item in hospedes)
            {
                if(!(item == null))
                {
                    Console.WriteLine("\n"+item);
                }
            }
        }
    }
}
