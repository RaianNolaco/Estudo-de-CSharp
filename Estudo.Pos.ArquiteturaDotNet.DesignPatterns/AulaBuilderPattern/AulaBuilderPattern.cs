using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaBuilderPattern
{
    static class AulaBuilderPattern
    {
        public static void executar()
        {

            var sanduicheBuilder = new SanduicheBuilder();
            var sanduiche = sanduicheBuilder.SetPao("forma")
                                            .SetCarne("frango")
                                            .SetQueijo("suiço").Build();

            sanduiche.mostrarInfoPedido();

        }
    }
}
