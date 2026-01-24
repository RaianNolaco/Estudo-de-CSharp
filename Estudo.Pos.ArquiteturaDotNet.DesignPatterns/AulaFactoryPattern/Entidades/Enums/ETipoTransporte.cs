using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaFactoryPattern.Entidades.Enums
{
    public enum ETipoTransporte
    {
        [Description("Rodoviario")]
        Rodoviario = 1,

        [Description("Ferroviario")]
        Ferroviario = 2,

        [Description("Aquatico")]
        Aquatico = 3

    }
}
