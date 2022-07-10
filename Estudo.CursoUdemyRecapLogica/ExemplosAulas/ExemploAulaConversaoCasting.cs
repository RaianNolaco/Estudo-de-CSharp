using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.RecapLogica.ExemplosAulas
{
    public class ExemploAulaConversaoCasting
    {
        public static void exemplo()
        {

            float a;
            double b;

            //conversão implicita
            a = 4.5f;
            b = a;

            Console.WriteLine("Conversão implicita: " + b);

            //casting
            /*
            Forma errada pois eu não possonjogar uma variavel tipo double em um tipo float diretamente
            pois o tipo doble possue 8 bytes e o float possue 4bytes
            b = 5.1;
            a = b;
            */

            b = 5.1;
            a = (float)b;
            Console.WriteLine("Conversão explcita casting: " + a);

            //casting Decimal para numero inteiro
            // perceba ao rodar o codigo q nesse caso perderemos informaçoes
            int c;
            c = (int)b;

            Console.WriteLine("COnversão Decimal para inteiro: " + c);

            //calculo com tipos diferentes
            int n1 = 5;
            int n2 = 2;
            double calc;

            calc = n1 / n2;
            Console.WriteLine("Calculo com tipos diferentes(sem casting): " + calc);

            calc = (double)n1 / n2;
            Console.WriteLine("Calculo com tipos diferentes(com casting): " + calc);

        }
    }
}