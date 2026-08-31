using Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaBuilderPatten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaBuilderPatten.Classes
{
    internal class Beverage : AMeal
    {
        public Beverage(string name, decimal price) : base(name, price){}
    }
}
