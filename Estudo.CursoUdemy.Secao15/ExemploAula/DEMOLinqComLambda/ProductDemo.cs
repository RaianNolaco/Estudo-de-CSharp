using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.ExemploAula.DEMOLinqComLambda
{
    public class ProductDemo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return ID + ", " + Name + ", " + Price.ToString("F2") + ", " + Category.Name + ", " + Category.Tier;
        }
    }
}
