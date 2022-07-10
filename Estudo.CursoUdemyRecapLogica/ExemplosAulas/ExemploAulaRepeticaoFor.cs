using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.RecapLogica.ExemplosAulas
{
    public class ExemploAulaRepeticaoFor
    {
        public static void exemplo()
        {
            int qnt = Utilitarios.pedirNumeroInteiro("quantos numeros você ira digitar?");
            int soma = 0;

            for (int i = 1;i <= qnt; i++)
            {
                int  valor = Utilitarios.pedirNumeroInteiro($"Valor #{i}: ");
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}
