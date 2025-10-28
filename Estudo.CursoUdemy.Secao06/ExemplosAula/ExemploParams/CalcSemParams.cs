using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploParms
{
    class CalcSemParams
    {
        public static double Soma(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            return sum;
        }
    }
}
