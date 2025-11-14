using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao13.ExemploAula.DictionaryESortedDictionary
{
    public static class DictionaryESortedDictionary
    {
        public static void executar()
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies.Add("nome","viper");
            cookies["email"] = "psssss@kingdom.com";
            cookies.Add("phone","111111");

            Console.WriteLine("Size: " + cookies.Count() + "\n");

            foreach (var item in cookies)
            {
                Console.WriteLine("Chave:" + item.Key);
                Console.WriteLine("valor:" + item.Value);
                Console.WriteLine();
            }

            cookies["phone"] = "22222222";
            Console.WriteLine(cookies["phone"]);


            cookies.Remove("phone");

            if (cookies.ContainsKey("phone"))
            {
                Console.WriteLine(cookies["phone"]);
            }
            else
            {
                Console.WriteLine("chave não existe ou foi apagada");
            }

            Console.WriteLine("Size: " + cookies.Count() + "\n");

            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine("Chave:" + item.Key);
                Console.WriteLine("valor:" + item.Value);
                Console.WriteLine();
            }
        }
    }
}
