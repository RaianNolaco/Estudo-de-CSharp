using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao10.ExemploAula.ExemploSobreposicaoEtc
{
    public static class SobreposicaoEtc
    {
        public static void Executar() {

            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccout(1002,"Ana",500, 0.01);
            SavingsAccout sacc1 = new SavingsAccout(1003, "Maria", 500, 0.01);
            

            acc1.Withdraw(10);
            acc2.Withdraw(10);
            sacc1.Withdraw(10);

            Console.WriteLine("Saldo conta 1: " + acc1.Balance);
            Console.WriteLine("Saldo conta 2: " + acc2.Balance);
            Console.WriteLine("Saldo conta 3: " + sacc1.Balance);


        }
    }
}
