using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao7.ExemploAula.ExemploDateTimeKind
{
    public class ExecDateTimeKind
    {
        public static void Executar()
        {
            DateTime d1 = new DateTime(2000,8,15,13,5,58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("Local: " +d1 +"\nUtc: "+ d2 +"\nSem nada: "+ d3);

            Console.WriteLine("\n============================\n");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind);
            Console.WriteLine("d1 local: " + d1.ToLocalTime());
            Console.WriteLine("d1 Utc: " + d1.ToUniversalTime());


            Console.WriteLine("\n============================\n");

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 local: " + d2.ToLocalTime());
            Console.WriteLine("d2 Utc: " + d2.ToUniversalTime());

            Console.WriteLine("\n============================\n");

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 kind: " + d3.Kind);
            Console.WriteLine("d3 local: " + d3.ToLocalTime());
            Console.WriteLine("d3 Utc: " + d3   .ToUniversalTime());

            Console.WriteLine("\n============================\n");
            Console.WriteLine("FALANDO SOBRE O PADRÃO ISO 8601\n");

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");


            Console.WriteLine(d4+"\n"+d5);



            Console.WriteLine("\n============================\n");

            Console.WriteLine("d4: " + d4);
            Console.WriteLine("d4 kind: " + d4.Kind);
            Console.WriteLine("d4 local: " + d4.ToLocalTime());
            Console.WriteLine("d4 Utc: " + d4.ToUniversalTime());

            Console.WriteLine("\n============================\n");

            Console.WriteLine("d5: " + d5);
            Console.WriteLine("d5 kind: " + d5.Kind);
            Console.WriteLine("d5 local: " + d5.ToLocalTime());
            Console.WriteLine("d5 Utc: " + d5.ToUniversalTime());

            Console.WriteLine("\n============================\n");


            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ") + "(Forma errada)");
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ") + "(Forma certa)");



        }
    }
}
