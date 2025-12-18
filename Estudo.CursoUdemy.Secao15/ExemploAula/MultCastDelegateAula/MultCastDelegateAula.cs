using Estudo.CursoUdemy.Secao15.ExemploAula.DelegateAula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.ExemploAula.MultCastDelegateAula
{
    public static class MultCastDelegateAula
    {
        delegate void BinaryNumericOperation(double n1, double n2);

        public static void executar()
        {
            double a = 10;
            double b = 12;

            var calc = new CalculationService();

            BinaryNumericOperation op = CalculationService.ShowMax;
            // BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.ShowMax);
            op += CalculationService.ShowMin;
            op += CalculationService.ShowSum;

            op(a, b);

            op -= CalculationService.ShowSum;
            op(a, b);

        }
    }
}
