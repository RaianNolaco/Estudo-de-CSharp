using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.ExemploAula.ComparisonAula
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ",  " + Price.ToString("F2",CultureInfo.InvariantCulture);
        }

        public int CompareTo(Product? other)
        {
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }
    }
}
