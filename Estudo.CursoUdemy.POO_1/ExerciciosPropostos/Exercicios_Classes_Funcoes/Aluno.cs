using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1.ExerciciosPropostos
{
    public class Aluno
    {
        public string Nome;
        public double PrimeiraNota;
        public double SegundaNota;
        public double TerceiraNota;


        public double NotaFinal(){
            return PrimeiraNota + SegundaNota + TerceiraNota;
        }

        public void ValidarNota()
        {
            if (NotaFinal() > 60)
            {
                Console.WriteLine("APROVADO");
                return;
            }

            Console.WriteLine("REPROVADO");
            Console.WriteLine("FALTARAM: " + (60 - NotaFinal()).ToString("F2",CultureInfo.InvariantCulture) + " PONTOS");
        }
    }
}
