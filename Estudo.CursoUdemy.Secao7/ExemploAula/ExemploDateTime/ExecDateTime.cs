using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao7.ExemploAula.ExemploDateTime
{
    class ExecDateTime
    {
        public static void Executar()
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine("d1 :"+d1);
            Console.WriteLine("d1 ticks :"+d1.Ticks);

            DateTime d2 = new DateTime(2002,11,11);
            DateTime d3 = new DateTime(2002, 11, 11, 20, 45, 3);
            DateTime d4 = new DateTime(2002, 11, 11, 20, 45, 3, 500);

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;


            DateTime d8 = DateTime.Parse("2002-11-11");
            DateTime d9 = DateTime.Parse("2002-11-11 13:05:58");
            DateTime d10 = DateTime.Parse("11/11/2002");
            DateTime d11 = DateTime.Parse("11/11/2002 13:05:58");
            DateTime d12 = DateTime.ParseExact("2002-11-11", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("11/11/2002 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine("d1 :"+d1);
            Console.WriteLine("d2 :"+d2);
            Console.WriteLine("d3 :"+d3);
            Console.WriteLine("d4 :"+d4);
            Console.WriteLine("d5 :"+d5);
            Console.WriteLine("d6 :"+d6);
            Console.WriteLine("d7 :"+d7);
            Console.WriteLine("d8 :"+d8);
            Console.WriteLine("d9 :"+d9);
            Console.WriteLine("d10 :"+d10);
            Console.WriteLine("d11 :"+d11);
            Console.WriteLine("d12 :"+d12);
            Console.WriteLine("d13 :"+d13);

        }
    }
}
