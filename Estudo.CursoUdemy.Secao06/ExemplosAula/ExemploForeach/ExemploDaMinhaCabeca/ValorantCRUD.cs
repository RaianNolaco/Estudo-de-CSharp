using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploForeach
{
    class ValorantCRUD
    {
       
        static AgentesValorant[] agentes = new AgentesValorant[13];
        public static void Cadastro()
        {
           

            //agentes[1].Nome = "Brimstone";
            //agentes[1].Classe = "Controlador";
            //agentes[1].Nacionalidade = "USA";
            //agentes[1].Numero = 1;

            Console.WriteLine("Cadatro Agentes: ");
            Console.Write("Quantos agente deseja cadastras: ");
            int qnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qnt; i++)
            {
                Console.Write("Digite o numero do agente: ");
                int numero = int.Parse(Console.ReadLine());
                agentes[numero].Numero = numero;

                Console.Write("Digite o nome do agente: ");
                agentes[numero].Nome = Console.ReadLine().ToUpper();

                Console.Write("Digite o sexo do Agente: \nH - Homen\n2M - Mulher");
                agentes[numero].Sexo = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Digite o nacionalidade do agente(Sigla do pais ex: USA,BR): ");
                agentes[numero].Nacionalidade = Console.ReadLine();

                Console.Write("Classe do agente: \n1 - Sentinela\n2 - Controlador\n3 - Iniciador\n4 - Duelista");
                int x = int.Parse(Console.ReadLine());

                bool sair = false;
                while (!sair)
                {
                    switch (x)
                    {
                        case 1:
                            agentes[numero].Classe = "Sentinela";
                            sair = true;
                            break;
                        case 3:
                            agentes[numero].Classe = "Controlador";
                            sair = true;
                            break;
                        case 4:
                            agentes[numero].Classe = "Iniciador";
                            sair = true;
                            break;
                        case 5:
                            agentes[numero].Classe = "Duelista";
                            sair = true;
                            break;

                        default:
                            Console.WriteLine("Classe invalida escolha apenas uma das a seguir: \n1 - Sentinela\n2 - Controlador\n3 - Iniciador\n4 - Duelista");
                            break;
                    }

                }
            }

            ExecForeach.Executar();
        }

        public static void Pesquisar()
        {
            Console.WriteLine("Por que filtro você ira pesquisar?\n1 - Sexo\n2 - Classe\n3 - Nacionalidade\n4 - Nome");
            int pesquisa = int.Parse(Console.ReadLine());

            switch (pesquisa)
            {
                case 1:

                    Console.WriteLine("homen ou mulher?\nH - homen\nM - Mulher");
                    char Sexo = char.Parse(Console.ReadLine().ToUpper());

                    foreach (var i in agentes)
                    {
                        if(i.Sexo == Sexo)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    break;

                case 2:
                    Console.WriteLine("homen ou mulher?\n1 - Sentinela\n2 - Controlador\n3 - Iniciador\n4 - Duelista");
                    int x = int.Parse(Console.ReadLine());
                    string classe;

                    switch (x)
                    {

                        case 1:
                            classe = "Sentinela";
                            break;
                        case 3:
                            classe = "Controlador";
                            break;
                        case 4:
                            classe = "Iniciador";
                            break;
                        case 5:
                            classe = "Duelista";
                            break;
                        default:
                            classe = " ";
                            break;
                    }


                    foreach (var i in agentes)
                    {
                        if (i.Classe == classe)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;

                case 3:
                   
                    Console.WriteLine("Qual a nacionalidade?Ex: USA...BR....");
                    string nacionalidade = Console.ReadLine().ToUpper();

                    foreach (var i in agentes)
                    {
                        if (i.Nacionalidade == nacionalidade)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("Qual o nome ?");
                    string nome = Console.ReadLine().ToUpper();

                    foreach (var i in agentes)
                    {
                        if (i.Nome == nome)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;

                default:
                    break;
            }

        }
    }
}
