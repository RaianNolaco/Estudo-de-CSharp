using Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaFactoryPattern.Entidades.Enums;
using Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaFactoryPattern.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaFactoryPattern.Entidades.Factories
{
    public static class TransporteFactory
    {
        public static ITransporte CreateTransporte(ETipoTransporte tipo)
        {
            ITransporte retorno = tipo switch
            {
                ETipoTransporte.Rodoviario => new TransporteRodoviario(),
                ETipoTransporte.Ferroviario => new TransporteFerroviario(),
                ETipoTransporte.Aquatico => new TransporteAquatico(),
                _ => throw new NotImplementedException("Tipo Invalido")
            };

            return retorno;
        }
    }
}
