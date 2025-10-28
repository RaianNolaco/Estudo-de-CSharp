namespace Estudo.CursoUdemy.Secao10.ExemploAula.ExemploUpDonwCast
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
