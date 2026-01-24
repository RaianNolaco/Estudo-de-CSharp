using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaSingletonPattern
{
    public class ContadorSingleton
    {
        private static ContadorSingleton? _instance;
        public int Valor { get; private set; }

        public static ContadorSingleton GetInstance { 
            get => _instance ??= new ContadorSingleton();
        }

        public void Incrementar() => Valor++;
    }
}
