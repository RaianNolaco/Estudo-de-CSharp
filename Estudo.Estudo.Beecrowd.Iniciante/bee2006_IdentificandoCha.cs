using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class bee2006_IdentificandoCha
    {
        public static void executar()
        {
            var tipoDeCha = Console.ReadLine();
            var respostas = Console.ReadLine().Split();

            var acerto = 0;
            foreach (var item in respostas)
            {
                if (tipoDeCha.Equals(item))               
                    acerto++;               
            }

            Console.WriteLine(acerto);
        }
    }
}
