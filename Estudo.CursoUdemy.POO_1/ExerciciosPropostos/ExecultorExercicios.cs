using Estudo.CursoUdemy.POO_1.ExerciciosPropostos.Exercicios_Classes_Estaticas;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1.ExerciciosPropostos
{
    public class ExecultorExercicios
    {
    
       public static void Pessoa()
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
    
        public static void Funcionario()
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

        public static void Retangulo()
        {
            Retangulo r = new Retangulo();

            Console.Write("Entre com a Largura e altura do triangulo em um mesma linha: ");
            string n = Console.ReadLine();
            string[] vet = n.Split(' ');

            r.Largura = double.Parse(vet[0]);
            r.Altura = double.Parse(vet[1]);

            Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = "+ r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIGITAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)  );

        }

        public static void FuncionarioDois()
        {
            FuncionarioDois funcionario = new FuncionarioDois();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("\nFuncionário: " + funcionario);

            Console.Write("\nDigite a porcentagem para aumentar o salario: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));

            Console.WriteLine("\nDados Atualizados: " + funcionario);
        }

        public static void Aluno()
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.PrimeiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            aluno.SegundaNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.TerceiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "+ aluno.NotaFinal());
            aluno.ValidarNota();
        }

        public static void ConversorMoeda()
        {

            Console.Write("Digite a cotação atual do dolar: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a Quantidade de Dolares que você ira comprar: ");
            double qnt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double convercao = ConversorDeMoeda.DolarParaReal(dolar, qnt);

            Console.WriteLine("Valor a ser pago em reais: R$" + convercao.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
