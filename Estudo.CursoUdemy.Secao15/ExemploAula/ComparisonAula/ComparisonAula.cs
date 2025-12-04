using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.ExemploAula.ComparisonAula
{
    public static class ComparisonAula
    {
        public static void executar()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV",900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet",450.00));

            list.Sort();

            foreach (Product p in list) {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
