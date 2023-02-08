using Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioResolvido_01.Entities.Enums;

namespace Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioResolvido_01.Entities
{
    public class Worker
    {
        public string Nome { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Departament Departament { get; set; }

        private List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker() { }

        public Worker(string nome, string level, double baseSalary, Departament departament)
        {
            Nome = nome;
            Level = Enum.Parse<WorkerLevel>(level);
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void remove(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double income(int month, int year)
        {
            double sum = BaseSalary;

            foreach (HourContract contrato in Contracts)
            {
                if(contrato.Data.Year == year && contrato.Data.Month == month)
                {
                    sum += contrato.totalValue();
                }
            }

            return sum;
        }
    }
}
