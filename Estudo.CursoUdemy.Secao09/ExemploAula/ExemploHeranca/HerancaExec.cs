namespace Estudo.CursoUdemy.Secao10.ExemploAula.ExemploHeranca
{
    public static class HerancaExec
    {
        public static void Executar(){
        
            Account contaA = new Account(1,"Fulano",100);

            Console.WriteLine("Conta A:" + contaA.Balance);

            contaA.Deposit(100);

            Console.WriteLine("Conta A:" + contaA.Balance);

            BusinessAccount contaB = new BusinessAccount(2, "Cicrano", 100, 200);

            Console.WriteLine("Conta B:" + contaB.Balance);

            contaB.Deposit(100);

            Console.WriteLine("Conta B:" + contaB.Balance);

            contaB.loan(100);
            
            Console.WriteLine("Conta B:" + contaB.Balance);

            contaB.loan(300);

            Console.WriteLine("Conta B:" + contaB.Balance);


        }
    }
}
