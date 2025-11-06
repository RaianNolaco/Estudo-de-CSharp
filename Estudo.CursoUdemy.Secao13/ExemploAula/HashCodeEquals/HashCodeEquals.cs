using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Estudo.CursoUdemy.Secao13.ExemploAula.HashCodeEquals
{
    public static class HashCodeEquals
    {
        public static void executar()
        {
            string a = "Maria";
            string b = "Alex";

            var c = "maria";
            var d = "alex";

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Equals(c));
            Console.WriteLine(b.Equals(d));
            Console.WriteLine(a.Equals(a));
            Console.WriteLine(a == c);


            Client cliente1 = new Client()
            {
                Name = a,
                Email = $"{a}@gmail.com",
            };

            Client cliente2 = new Client()
            {
                Name = a,
                Email = $"{a}@gmail.com",
            };

            Client cliente3 = new Client()
            {
                Name = c,
                Email = $"{c}@gmail.com",
            };

            Client cliente4 = new Client()
            {
                Name = c,
                Email = $"{a}@gmail.com",
            };

            Console.WriteLine(cliente1.Equals(cliente2));
            Console.WriteLine(cliente1.Equals(cliente3));
            Console.WriteLine(cliente2.Equals(cliente4));
            Console.WriteLine(cliente4.Equals(cliente1));
            
        }
    }
}
