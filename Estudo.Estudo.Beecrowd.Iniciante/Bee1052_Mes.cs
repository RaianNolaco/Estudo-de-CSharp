using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1052_Mes
    {
        public static void executar()
        {
            int mes = int.Parse(Console.ReadLine());            
            DateTime dataBase = new DateTime();   
            var mesNome = dataBase.AddMonths(mes - 1).ToString("MMMM");
            Console.WriteLine(mesNome);
        }
    }
}
