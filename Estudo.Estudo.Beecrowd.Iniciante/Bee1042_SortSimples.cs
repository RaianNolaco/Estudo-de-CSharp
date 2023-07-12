using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1042_SortSimples
    {
        public static void executar()
        {

            string[] valoresTxt = Console.ReadLine().Split();

            decimal[] valores = new decimal[valoresTxt.Length];
            for (int i = 0; i < valoresTxt.Length; i++)
            {
                decimal.TryParse(valoresTxt[i], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valorConvertido);
                valores[i] = valorConvertido;
            }

            decimal n1 =  valores[0];
            decimal n2 =  valores[1];
            decimal n3 =  valores[2];

            decimal[] valoresOrdenados = valores;

  

            for (int i = 0; i < valores.Length; i++)
            {
 
            }
            


        }
    }
}
