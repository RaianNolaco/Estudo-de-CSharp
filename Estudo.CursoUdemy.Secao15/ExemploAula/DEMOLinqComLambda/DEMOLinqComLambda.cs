using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.ExemploAula.DEMOLinqComLambda
{
    public static class DEMOLinqComLambda
    {
        public static void executar()
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 2, Name = "Eletronics", Tier = 1 };

            List<ProductDemo> products = new List<ProductDemo>()
            {
                new ProductDemo() { ID = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new ProductDemo() { ID = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new ProductDemo() { ID = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new ProductDemo() { ID = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new ProductDemo() { ID = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new ProductDemo() { ID = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new ProductDemo() { ID = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new ProductDemo() { ID = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new ProductDemo() { ID = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new ProductDemo() { ID = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new ProductDemo() { ID = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            print("todos produtos", products);

            var r1 = products.Where( x => x.Category.Tier.Equals(1) && x.Price < 900);
            print("Prudotos tier 1 por menos de 900", r1);

            var r2 = products.Where(x => x.Category.Name.Equals("Tools"))
                             .Select(x => x.Name);

            print("Nome das ferramentas com C", r2);

            var r3 = products.Where(x => x.Name[0] == 'C')
                             .Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name });

            print("Nome iniciados com C", r3);

            var r4 = products.Where(x => x.Category.Tier ==1)
                             .OrderBy(x => x.Price).ThenBy(n => n.Name);

            print("Produtos tier 1 por preço", r4);

            var r5 = r4.Skip(2)
                       .Take(4);

            print("Pulando 2 e pegando 4", r5);


            var r6 = products.First();
          
            Console.WriteLine("Primeiro produto:  " + r6);

            //var r7 = products.Where(p => p.Price > 3000).First();
            //Console.WriteLine("Primeiro produto:  " + r7);

            var r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine("firtOrDefault produto:  " + r7);


            var r8 = products.Where(p => p.ID == 3).SingleOrDefault();
            Console.WriteLine("SingleOrDefault produto:  " + r8);

            var r9 = products.Where(p => p.ID == 30).SingleOrDefault();
            Console.WriteLine("SingleOrDefault produto:  " + r9);

            var r10 = products.Max(x => x.Price);
            Console.WriteLine("Max: " + r10);

            //var r101 = products.Max();
            //Console.WriteLine("Max sozinho:  " + r101);

            var r11 = products.Min(x => x.Price);
            Console.WriteLine("Min: " + r11);

            var r12 = products.Where(x => x.Category.Id == 1)
                              .Sum(x => x.Price);
            Console.WriteLine("Soma dos preços da categoria 1: " + r12);

            var r13 = products.Where(x => x.Category.Id == 1)
                              .Average(x => x.Price);
            Console.WriteLine("media dos preços da categoria 1: " + r13);

            var r14 = products.Where(x => x.Category.Id == 5)
                              .Select(x => x.Price)
                              .DefaultIfEmpty(0)
                              .Average();
            Console.WriteLine("media dos preços da categoria 5: " + r14);

            var r15 = products.Where(x => x.Category.Id == 1)
                              .Select(x => x.Price)
                              .Aggregate(0.0, (x,y) => x + y);
            Console.WriteLine("soma por Agragação dos preços da categoria 1: " + r15);

            var r16 = products.GroupBy(p => p.Category);

            foreach (IGrouping<Category, ProductDemo> group in r16)
            {
                Console.WriteLine("\nCategoria: " + group.Key.Name);
                //group.ToList().ForEach(Console.WriteLine);

                foreach (ProductDemo item in group)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

        }

        public static void print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection){ Console.WriteLine(obj); }
            Console.WriteLine();
        }
    }
}
