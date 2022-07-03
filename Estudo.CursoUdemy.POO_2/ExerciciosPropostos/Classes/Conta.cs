using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_2.ExerciciosPropostos.Classes
{
    class Conta
    {
        public double Saldo { get; private set; }
        public int Numero { get; private set; }
        public string Nome { get; set; }

        public Conta(int numero, string nome, double saldo = 0.0)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            valor += 5;

            if(valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                Saldo -= valor;
            }
        }

        public override string ToString()
        {
            return $"Conta {Numero}, "+
                   $"Titula {Nome}, "+
                   $"Saldo ${Saldo.ToString("F2" + CultureInfo.InvariantCulture)}";
        }
    }
}
