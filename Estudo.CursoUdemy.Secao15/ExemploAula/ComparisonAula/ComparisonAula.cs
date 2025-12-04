using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

            Comparison<Product> comp = CompareProductPrice;
            Comparison<Product> compComLamda = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            

            // é uma delegate pegando direto o metodo que ira usar
            list.Sort(CompareProductName);
            foreach (Product p in list)
            {
                Console.WriteLine(p.ToString());
            }
            // usando uma variavel para guardar o metodo
            Console.WriteLine("===================");

            list.Sort(comp);
            foreach (Product p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("===================");

            // usando uma variavel com uma expressão lambda
            list.Sort(compComLamda);
            foreach (Product p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("===================");

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            foreach (Product p in list)
            {
                Console.WriteLine(p.ToString());
            }

        }

        static int CompareProductName(Product p1, Product p2)
        {
           return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
        static int CompareProductPrice(Product p1, Product p2)
        {
           return p1.Price.CompareTo(p2.Price);
        }
    }
}
