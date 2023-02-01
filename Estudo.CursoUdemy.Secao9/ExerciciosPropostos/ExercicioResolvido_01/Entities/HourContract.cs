namespace Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioResolvido_01.Entities
{
    public class HourContract
    {
        public DateTime Data { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(){}
        public HourContract(DateTime data, double valuePerHour, int hours)
        {
            Data = data;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double totalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}