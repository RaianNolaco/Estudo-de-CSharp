using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1.ExerciciosPropostos.Exercicios_Classes_Estaticas
{
    public static class ConversorDeMoeda
    {
        public static double Iof = 0.06;
        

        public static double DolarParaReal(double cotacaoDolar, double qnt)
        {
            double calc = cotacaoDolar * qnt;
            calc += calc * Iof;
            return calc;
        }
    }
}
