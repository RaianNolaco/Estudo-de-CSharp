using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao7.ExemploAula.ExemploTimeSpan_II
{
    public class ExecTimeSpan_II
    {
        public static void Executar()
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

           

            Console.WriteLine("Valor maximo: " + t1);
            Console.WriteLine("Valor minimo: " + t2);
            Console.WriteLine("Valor zero: " + t3);
            

            Console.WriteLine("\n========================\n");

            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);
            
            Console.WriteLine("Time span: " + t4);
            Console.WriteLine("Dias: " + t4.Days);
            Console.WriteLine("Horas: " + t4.Hours);
            Console.WriteLine("Minutos: " + t4.Minutes);
            Console.WriteLine("Segundos: " + t4.Seconds);
            Console.WriteLine("Millisegundos: " + t4.Milliseconds);
            Console.WriteLine("Tiks: " + t4.Ticks);

            Console.WriteLine();
            
            Console.WriteLine("Total de Dias: " + t4.TotalDays);
            Console.WriteLine("Total de Horas: " + t4.TotalHours);
            Console.WriteLine("Total de Minutos: " + t4.TotalMinutes);
            Console.WriteLine("Total de Segundos: " + t4.TotalSeconds);
            Console.WriteLine("Total de Millisegundos: " + t4.TotalMilliseconds);

            Console.WriteLine("\n========================\n");


            TimeSpan calcT1 = new TimeSpan(1,30,10);
            TimeSpan calcT2 = new TimeSpan(0,10,5);

            TimeSpan soma = calcT1.Add(calcT2);
            TimeSpan subtracao = calcT1.Subtract(calcT2);
            TimeSpan multiplicacao = calcT2.Multiply(2.0);
            TimeSpan divisao = calcT2.Divide(2);

            Console.WriteLine("calcT1: " + calcT1);
            Console.WriteLine("calcT2: " + calcT2);

            Console.WriteLine();

            Console.WriteLine("calcT1 + calcT2: " + soma);
            Console.WriteLine("calcT1 - calcT2: " + subtracao);
            Console.WriteLine("calcT2 * 2: " + multiplicacao);
            Console.WriteLine("calcT2 / 2: " + divisao);





        }
    }
}
