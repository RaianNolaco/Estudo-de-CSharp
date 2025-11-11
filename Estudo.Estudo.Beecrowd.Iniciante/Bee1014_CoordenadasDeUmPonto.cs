using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1014_CoordenadasDeUmPonto
    {
        public static void executar()
        {
            var numeros = Console.ReadLine().Split();

            var sinalX = Math.Sign(double.Parse(numeros[0], CultureInfo.InvariantCulture));
            var sinalY = Math.Sign(double.Parse(numeros[1], CultureInfo.InvariantCulture));

            var result = (sinalX, sinalY) switch
            {
                (1, 1)   => "Q1",
                (-1, 1)  => "Q2",
                (-1, -1) => "Q3",
                (1, -1)  => "Q4",                
                (0, 1)   => "Eixo Y",
                (1, 0)   => "Eixo X",
                (0, -1)  => "Eixo Y",
                (-1, 0)  => "Eixo X",
                (0, 0)   => "Origem",
            };

            Console.WriteLine(result);
        }

        public static void versaoQuePassou()
        {
            var numeros = Console.ReadLine().Split();

            var convercaoX = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            var convercaoY = double.Parse(numeros[1], CultureInfo.InvariantCulture);

            var sinalX = Math.Sign(convercaoX);
            var sinalY = Math.Sign(convercaoY);

            string result = "";
            if (sinalX == 1 && sinalY == 1)
            {
                result = "Q1";
            }
            else if (sinalX == -1 && sinalY == 1)
            {
                result = "Q2";
            }
            else if (sinalX == -1 && sinalY == -1)
            {
                result = "Q3";
            }
            else if (sinalX == 1 && sinalY == -1)
            {
                result = "Q4";
            }
            else if (sinalX == 0 && sinalY == 1)
            {
                result = "Eixo Y";
            }
            else if (sinalX == 1 && sinalY == 0)
            {
                result = "Eixo X";
            }
            else if (sinalX == 0 && sinalY == -1)
            {
                result = "Eixo Y";
            }
            else if (sinalX == -1 && sinalY == 0)
            {
                result = "Eixo X";
            }
            else if (sinalX == 0 && sinalY == 0)
            {
                result = "Origem";
            }

            Console.WriteLine(result);
        }
    }
}
