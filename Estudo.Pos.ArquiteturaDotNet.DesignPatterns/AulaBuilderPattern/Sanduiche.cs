using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaBuilderPattern
{
    public class Sanduiche
    {
        public string Pao { get; set; }
        public string Carne { get; set; }
        public string Queijo { get; set; }
        public bool TemSalada { get; set; }

        public Sanduiche(string pao, string carne, string queijo, bool temSalada)
        {
            Pao = pao;
            Carne = carne;
            Queijo = queijo;
            TemSalada = temSalada;
        }

        public void mostrarInfoPedido()
        {
            var texto = $"Sanduiche: Pão {Pao} com {Carne}";
            texto += $" queijo {Queijo} "; 
            texto += (TemSalada ? $"com" : "sem") + " Salada";

            Console.WriteLine(texto);
        }
    }
}
