using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.ExemploAula.DelegateAula
{
    delegate double BinaryNumericOperation(double n1, double n2);

    public static class DelegateAula
    {
        public static void executar()
        {
            double a = 10;
            double b = 12;

            var calc = new CalculationService();

            BinaryNumericOperation op = CalculationService.Max;
            BinaryNumericOperation op3 = calc.Min;
            // BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Max);
            //BinaryNumericOperation op2 = ;


            //double result = CalculationService.Square(a);
            double result = op(a,b);
            //double result = op.Invoke(a,b);
            Console.WriteLine(result);
        }
    }
}
