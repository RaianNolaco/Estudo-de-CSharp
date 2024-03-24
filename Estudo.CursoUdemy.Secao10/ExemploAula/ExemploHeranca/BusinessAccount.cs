﻿using Estudo.CursoUdemy.Secao10.ExemploAula.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Estudo.CursoUdemy.Secao10.ExemploAula.ExemploHeranca
{
    internal class BusinessAccount : Account
    {

        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) 
        {
            LoanLimit = loanLimit;
        }
        
        public void loan(double amount)
        {
            if (amount <= LoanLimit)
                Balance += amount;
            else
                Console.WriteLine("Limite indisponivel");

        }
    }
}
