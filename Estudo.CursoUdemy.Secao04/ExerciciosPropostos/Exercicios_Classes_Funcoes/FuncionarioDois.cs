using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1.ExerciciosPropostos
{
    class FuncionarioDois
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double poncentagem)
        {
            SalarioBruto += SalarioBruto * (poncentagem / 100);
        }

        public override string ToString()
        {
            return $"{Nome}, ${SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}" ;
        }
    }
}
