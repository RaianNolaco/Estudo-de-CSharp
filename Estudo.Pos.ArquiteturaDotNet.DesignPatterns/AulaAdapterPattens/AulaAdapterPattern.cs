using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaAdapterPattens
{
    public static class AulaAdapterPattern
    {
        public static void executar()
        {
            var xmlMessage = new XmlMessage();

            IJsonMessage adapterMessage = new XmlToJsonAdapter(xmlMessage);


            var xml = xmlMessage.Xml;
            var json = adapterMessage.Json;

            Console.WriteLine($"[XML]");
            Console.WriteLine(xml);

            Console.WriteLine($"[Json]");
            Console.WriteLine(json);
        }
    }
}
