using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao10.ExemploAula.ExemploUpDonwCast
{
    public static class UpDonwCastExec
    {
        public static void Executar()
        {
            Account acc=  new Account(1001,"Alex",0);
            BusinessAccount bacc = new BusinessAccount(1002,"Maria",0,500);

            //UPCASTING

            //Converção ocorre inplicitamente
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003,"Bob",0.0,200);
            Account acc3 = new SavingsAccout(1004, "Ana", 0, 0.01);


            //DOWNCAST
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.loan(200);


            if (acc3 is BusinessAccount)
            {
               // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.loan(200);
                Console.WriteLine("Laon");
            }


            if (acc3 is SavingsAccout) {

                //SavingsAccout acc5 = (SavingsAccout)acc3;
                SavingsAccout acc5 = acc3 as SavingsAccout;
                acc5.UpDateBalance();
                Console.WriteLine("Update");
            }

            var a = 23.56;

            if(a is int)
            {
                int b = (int)a; 
            }


        }
    }
}
