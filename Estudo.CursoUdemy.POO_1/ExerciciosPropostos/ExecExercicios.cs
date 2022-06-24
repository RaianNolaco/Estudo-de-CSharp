using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1.ExerciciosPropostos
{
    public class ExecExercicios
    {
    
       public static void pessoa()
        {
            Pessoa primeira = new Pessoa();
            Pessoa segunda = new Pessoa();
            string maisVelha;

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write($"Nome: ");
            primeira.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            primeira.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write($"Nome: ");
            segunda.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            segunda.idade = int.Parse(Console.ReadLine());

            if(primeira.idade > segunda.idade)
            {
                maisVelha = primeira.Nome;
            }
            else
            {
                maisVelha = segunda.Nome;
            }

            Console.WriteLine($"Pessoa mais velha:{maisVelha}");
        }
    
        public static void funcionario()
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados primeiro funcionario: ");
            
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados segundo funcionario: ");
            
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.Salario + funcionario2.Salario) / 2;
            Console.WriteLine($"Salario médio: {media.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}
