using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExerciciosPropostos.ExercicoListas
{
    class ExecFuncionario
    {
        public static void Execultar()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();  

            Console.Write("Quantos funcioonarios você deseja adicionar?");
            int qnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qnt; i++)
            {
                Console.WriteLine("\nFuncionario #" + i);
                int id;
                while (true)
                {
                    Console.Write("Digite o Id do funcionario: ");
                    id = int.Parse(Console.ReadLine());

                    if((funcionarios.FindIndex(x => x.Id == id) == -1))
                    {
                        break;
                    }

                    Console.WriteLine("Id já existente");
                }


                Console.Write("Digite o nome do funcionario: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o salario do funcionario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Funcionario funcionario = new Funcionario(id,nome,salario);
                funcionarios.Add(funcionario);
            }

            Console.WriteLine("\nLista de funcionarios");
            foreach (var item in funcionarios)
            {
                Console.Write(item + "\n");
            }

            int posicaoAumento;
            while (true)
            {
                Console.Write("\nDigite o Id do funcionario que você deseja fazer o aumento no salario: ");
                int idAumento = int.Parse(Console.ReadLine());
                posicaoAumento = funcionarios.FindLastIndex(x => x.Id == idAumento);

                if (!(posicaoAumento < 0))
                    break;
               
                Console.WriteLine("Funcionario inexistente");
                 Console.WriteLine("Digite um id valido");
              
            }

            Console.Write("Digite a porcentagem do aumento: ");
            double aumento = double.Parse(Console.ReadLine());

            funcionarios[posicaoAumento].AumentarSalario(aumento);

            Console.WriteLine("\nLista de funcionarios Atualizada");
            foreach (var item in funcionarios)
            {
                Console.Write(item + "\n");
            }
        }
    }
}
