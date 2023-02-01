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

        public Worker(string nome, WorkerLevel level, double baseSalary, Departament departament)
        {
            Nome = nome;
            Level = level;
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

        public double income(int year, int month)
        {
            return 0;
        }
    }
}
