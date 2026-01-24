using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaSingletonPattern
{
    public static  class AulaSingletonPattern
    {
        public static void executar()
        {
            ContadorSingleton c1,c2,c3;

            c1 = ContadorSingleton.GetInstance;
            c2 = ContadorSingleton.GetInstance;
            c3 = ContadorSingleton.GetInstance;

            c1.Incrementar();
            c2.Incrementar();
            c3.Incrementar();

            Console.WriteLine($"c1:{c1.Valor}\nc2:{c2.Valor}\nc2:{c3.Valor}");
        }
    }
}
