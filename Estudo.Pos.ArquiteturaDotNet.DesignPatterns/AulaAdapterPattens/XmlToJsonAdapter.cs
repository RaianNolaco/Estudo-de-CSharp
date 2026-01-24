using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaAdapterPattens
{
    public class XmlToJsonAdapter : IJsonMessage
    {
        private readonly XmlMessage _xmlMessage;

        public XmlToJsonAdapter(XmlMessage xmlMessage)
        {
            _xmlMessage = xmlMessage;
        }

        public string Json {
            get {
                var xml = _xmlMessage.Xml;
                var xmlElement = XElement.Parse(xml);
                var result = JsonConvert.SerializeXNode(xmlElement);

                return result;
             }         
        }
    }
}
