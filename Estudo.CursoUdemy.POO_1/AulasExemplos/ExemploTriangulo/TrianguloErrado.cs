using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1.AulasExemplos
{
    class TrianguloErrado
    {
        public static void trianguloAula38Errado()
        {

            Console.WriteLine("Digite as medidos de um triangulo: ");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidos de um triangulo: ");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double xP = (xA + xB + xC) / 2;
            double yP = (yA + yB + yC) / 2;

            double areaX = Math.Sqrt(xP * (xP - xA) * (xP - xB) * (xP - xC));
            double areaY = Math.Sqrt(yP * (yP - yA) * (yP - yB) * (yP - yC));

            Console.WriteLine("Área de X: " + areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areaY.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Maior area: " + (areaX > areaY ? "X" : "Y"));

        }
    }
}
