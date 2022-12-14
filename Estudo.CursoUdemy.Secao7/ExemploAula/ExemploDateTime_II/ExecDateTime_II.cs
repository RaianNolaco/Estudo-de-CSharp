using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao7.ExemploAula.ExemploDateTime_II
{
    internal class ExecDateTime_II
    {
        public static void Executar()
        {
            DateTime d0 = new DateTime(2002,11,11,00,01,30, 300);

            Console.WriteLine(d0);
            Console.WriteLine("Dia: " + d0.Day);
            Console.WriteLine("Dia da semana: " + d0.DayOfWeek);
            Console.WriteLine("Dia do ano: " + d0.DayOfYear);
            Console.WriteLine("Hora: " + d0.Hour);
            Console.WriteLine("Kind: " + d0.Kind);
            Console.WriteLine("Milisegundos: " + d0.Millisecond);
            Console.WriteLine("Minuto: " + d0.Minute);
            Console.WriteLine("Mes: " + d0.Month);
            Console.WriteLine("Segundos: " + d0.Second);
            Console.WriteLine("Tiks: " + d0.Ticks);
            Console.WriteLine("horas do dia: " + d0.TimeOfDay);
            Console.WriteLine("ano: " + d0.Year);

            Console.WriteLine("-----------");

            Console.WriteLine(d0.ToLongDateString());
            Console.WriteLine(d0.ToLongTimeString());
            Console.WriteLine(d0.ToShortDateString());
            Console.WriteLine(d0.ToShortTimeString());
            Console.WriteLine(d0.ToString());

            Console.WriteLine(d0.ToString("yyyy/mm/dd  HH:mm:ss"));
            Console.WriteLine(d0);


            Console.WriteLine("Adicionando 2 horas: " + d0.AddHours(2));
            Console.WriteLine("Adicionar 30 minutos: " + d0.AddMinutes(30));

            DateTime d1 = DateTime.Now;

            Console.WriteLine("Data atual: " + d1);
            Console.WriteLine("Data atual + 7 dias: " + d1.AddDays(7));

            Console.WriteLine("Diferença de uma data para outra: " + d1.Subtract(d0));

        }
    }
}
