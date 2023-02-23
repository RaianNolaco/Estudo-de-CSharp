using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1019_ConversaoTempo
    {
        public static void executar()
        {
            int tempoSegundos = int.Parse(Console.ReadLine());

            double horas = 0;
            double minutos = 0;
            double segundos = 0;
            int auxiliar = 0;

            while(tempoSegundos > 0)
            {
                if (tempoSegundos >= 3600)
                {
                    horas = tempoSegundos / 3600;

                    auxiliar = (int)horas * 3600;
                    tempoSegundos -= auxiliar;
                    minutos = tempoSegundos % 3600;

                }
                else if (tempoSegundos >= 60)
                {
                    minutos = tempoSegundos / 60;
                    segundos = tempoSegundos % 60;

                    auxiliar = (int)(minutos * 60 + segundos);
                    tempoSegundos -= auxiliar;
                }
                else
                {
                    segundos = tempoSegundos;
                    tempoSegundos -= (int)segundos;
                }
            }
            

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }

        public static void forma2()
        {
            int duracaoSegundos = int.Parse(Console.ReadLine());

            int horas = duracaoSegundos / 3600;
            int minutos = (duracaoSegundos % 3600) / 60;
            int segundos = (duracaoSegundos % 3600) % 60;

            Console.WriteLine($"{horas}:{minutos:D2}:{segundos:D2}");
        }
    }
}
