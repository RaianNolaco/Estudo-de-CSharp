using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1
{
    class Triangulo
    {
        // aula 39 - classs e atributos
        public double A;
        public double B;
        public double C;

        // aula 41 - metodos

        public double Area()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}