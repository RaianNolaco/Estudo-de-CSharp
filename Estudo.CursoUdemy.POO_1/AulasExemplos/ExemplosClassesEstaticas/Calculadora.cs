using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1.AulasExemplos.ExemplosClassesEstaticas
{
    public static class Calculadora
    {
        public static double PI = 3.14;
        public static double Circunferecia(double r)
        {
            return 2.0 * PI * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * PI * r * r * r;
        }
    }
}
