using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.POO_1.AulasExemplos
{
    public class TrianguloAulaClasses
    {
       public static void TrianguAula39Classes()
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();



            Console.WriteLine("Digite as medidos de um triangulo: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidos de um triangulo: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double xP = (x.A + x.B + x.C) / 2;
            double yP = (y.A + y.B + y.C) / 2;

            double areaX = Math.Sqrt(xP * (xP - x.A) * (xP - x.B) * (xP - x.C));
            double areaY = Math.Sqrt(yP * (yP - y.A) * (yP - y.B) * (yP - y.C));

            Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Maior area: " + (areaX > areaY ? "X" : "Y"));

        }
    }
}
