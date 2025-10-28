using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao10.ExemploAula.ExemploSobreposicaoEtc
{
    public class SavingsAccout : Account
    {

        public double InterestRate { get; set; }

        public SavingsAccout()
        {
        }

        public SavingsAccout(int number, string holder, double balance, double interestRate)
            :base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpDateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2;
        }

    }
}
