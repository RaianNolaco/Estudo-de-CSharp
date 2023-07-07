using System;
using System.Globalization;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1043_IdentificaTriangulo
    {
        public static void executar()
        {
           

            string[] valoresTxt = Console.ReadLine().Split();

            decimal[] valoresNum = new decimal[valoresTxt.Length];
            for (int i = 0; i < valoresTxt.Length; i++)
            {
                decimal.TryParse(valoresTxt[i], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valorConvertido);
                valoresNum[i] = valorConvertido;
            }
            decimal a = valoresNum[0];
            decimal b = valoresNum[1];
            decimal c = valoresNum[2];

            bool ladoEhMaior = (a + b > c) && (a + c > b) && (c + b > a);


            if (ladoEhMaior)
            {
                decimal calcTriangulo = a + b + c;
                Console.WriteLine("Perimetro = " + calcTriangulo.ToString("N1"));
            }
            else
            {
                decimal calcTrapezio = (a + b) * c / 2;
                Console.WriteLine("Area = " + calcTrapezio.ToString("N1"));
            }


        }
    }
}
