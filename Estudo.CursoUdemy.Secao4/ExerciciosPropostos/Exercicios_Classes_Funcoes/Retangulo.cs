using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1.ExerciciosPropostos
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2*(Largura + Altura);
        }

        public double Diagonal()
        {
            double potencias = Math.Pow(Largura, 2) + Math.Pow(Altura, 2);
            return Math.Sqrt(potencias);
        }
    }
}
