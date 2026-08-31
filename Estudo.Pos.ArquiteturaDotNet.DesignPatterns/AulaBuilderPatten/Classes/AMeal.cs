using Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaBuilderPatten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaBuilderPatten.Classes
{
    public abstract class AMeal : IMealComposite
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public AMeal(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public decimal GetPrice()
        {
            return Price;
        }
    }
}
