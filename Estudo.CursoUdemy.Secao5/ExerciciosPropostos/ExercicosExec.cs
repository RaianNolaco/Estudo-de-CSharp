using Estudo.CursoUdemy.POO_2.ExerciciosPropostos.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_2.ExerciciosPropostos
{
    public class ExercicosExec
    {
        public static void exercico()
        {
            int numero;
            string nome;
            Conta c1;

            Console.Write("Digite o numero da conta: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Digite nome do titular da conta: ");
            nome = Console.ReadLine();

            Console.WriteLine("Deseja fazer um deposito inicial (S/N)?");
            string resp = Console.ReadLine();


            if (resp == "S" || resp == "s")
            {
                Console.Write("Digite o valor que deseja depositar: ");
                double saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                c1 = new Conta(numero, nome, saldo);
            }
            else
            {
                c1 = new Conta(numero, nome);
            }


            Console.WriteLine("\nDados da conta:\n" + c1);

            Console.Write("\nDigite o valor que deseja depositar: ");
            c1.Depositar(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados: " + c1);

            Console.Write("\nDigite o valor que deseja sacar: ");
            c1.Sacar(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados: " + c1);


        }
    }
}
