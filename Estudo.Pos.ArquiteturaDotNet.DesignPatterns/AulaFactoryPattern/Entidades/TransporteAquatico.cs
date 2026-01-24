using Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaFactoryPattern.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaFactoryPattern.Entidades
{
    public class TransporteAquatico : ITransporte
    {
        public void Entregar()
        {
            Console.WriteLine("Entregando via aquaticas");
        }
    }
}
