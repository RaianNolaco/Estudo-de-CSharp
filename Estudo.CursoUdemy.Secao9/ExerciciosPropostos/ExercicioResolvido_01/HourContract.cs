namespace Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioResolvido_01
{
    public class HourContract
    {
        public DateTime Data { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours{ get; set; }

        public double totalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}