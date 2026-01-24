using Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaFactoryPattern.Entidades.Enums;
using Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaFactoryPattern.Entidades.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaFactoryPattern
{
    public static class AulaFactoryPattern
    {
        public static void executar()
        {
            var t1 = TransporteFactory.CreateTransporte(ETipoTransporte.Rodoviario);
            var t2 = TransporteFactory.CreateTransporte(ETipoTransporte.Ferroviario);
            var t3 = TransporteFactory.CreateTransporte(ETipoTransporte.Aquatico);

            t1.Entregar();
            t2.Entregar();
            t3.Entregar();
        }
    }
}
