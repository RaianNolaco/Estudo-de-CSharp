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

            //string[] valoresTxt = Console.ReadLine().Split();

            //decimal[] valores = new decimal[valoresTxt.Length];
            //for (int i = 0; i < valoresTxt.Length; i++)
            //{
            //    decimal.TryParse(valoresTxt[i], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal valorConvertido);
            //    valores[i] = valorConvertido;
            ////}
            ///
            //decimal n1 =  valores[0];
            //decimal n2 =  valores[1];
            //decimal n3 =  valores[2];


            decimal[] valores = new decimal[3];

            valores[0] = 7;
            valores[1] = 21;
            valores[2] = -14;

            decimal[] valoresOrdenados = new decimal[valores.Length];
            decimal menorValor = 0;
            decimal maiorValor = 0;
            bool taNalista = false;

            for (int i = 0; i < valores.Length; i++)
            {
                maiorValor = valores[i];
               
                for (int j = 0; j < valores.Length; j++)
                {                                  
                    if (maiorValor < valores[j])
                    {
                        for (int x = 0; x < valoresOrdenados.Length; x++)
                        {
                            taNalista = valores[j] == valoresOrdenados[x];
                            if (taNalista)
                                break;
                            
                        }
                        if (!taNalista)
                        {
                            maiorValor = valores[j];
                        }
                    }                
                }
                Console.WriteLine(maiorValor);
                valoresOrdenados[i] = maiorValor;
            }


            //for (int i = 0; i < valores.Length; i++)
            //{
            //    menorValor = valores[i];
               
            //    for (int j = 0; j < valores.Length; j++)
            //    {                                  
            //        if (menorValor > valores[j])
            //        {
            //            for (int x = 0; x < valoresOrdenados.Length; x++)
            //            {
            //                taNalista = valores[j] == valoresOrdenados[x];
            //                if (taNalista)
            //                    break;
                            
            //            }
            //            if (!taNalista)
            //            {
            //                menorValor = valores[j];
            //            }
            //        }                
            //    }
            //    Console.WriteLine(menorValor);
            //    valoresOrdenados[i] = menorValor;
            //    valorPassado = menorValor;
            //}

            //var a = n1 < n2;
            //var b = n1 < n3;
            /* true
             * true 
             * 
             * n1 é menor 
             * 
             * true 
             * false 
             * 
             * n3 é o menor
             * 
             * false 
             * true
             * 
             * n2 é o menor 
             */


            //var c = n2 < n1;
            //var d = n2 < n3;
            /* true
           * true 
           * 
           * n2 é menor 
           * 
           * true 
           * false 
           * 
           * n2 é o menor
           * 
           * false 
           * true
           * 
           * n3 é o menor 
           */

            //var e = n3 < n1;
            //var f = n3 < n2;
            /* true
           * true 
           * 
           * n3 é menor 
           * 
           * true 
           * false 
           * 
           * n1 é o menor
           * 
           * false 
           * true
           * 
           * n1 é o menor 
           */

        }
    }
}
