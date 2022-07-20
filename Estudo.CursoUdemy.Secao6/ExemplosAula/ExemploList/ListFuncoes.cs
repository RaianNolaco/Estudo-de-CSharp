using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploList
{
    class ListFuncoes
    {
        public static void Manipulandodados()
        {
            List<string> nomes = new List<string>();

            Console.WriteLine("\nAdicionando com Add: \n");
            nomes.Add("Naruto");
            nomes.Add("Sasuke");
            nomes.Add("Sakura");
            nomes.Add("Kakashi");
            nomes.Add("Itachi");
            nomes.Add("Karkuro");
            nomes.Add("Madara");
            nomes.Add("Kiba");
            nomes.Add("Nagato");
            nomes.Add("Gaara");
            nomes.Add("Neji");
            nomes.Add("Konan");
            nomes.Add("Zabuza");
            nomes.Add("Hashirama");

            foreach (string personagem in nomes)
            {
                Console.WriteLine(personagem);
            }

            Console.WriteLine("\nAdicionando com Insert: \n");
            nomes.Insert(1,"Gai");
            nomes.Insert(3,"Obito");
            nomes.Insert(4,"Karin");
            nomes.Insert(5,"Minato");
            nomes.Insert(6,"Kisame");
            nomes.Insert(7,"Gaara");
            nomes.Insert(10,"Hinata");
            nomes.Insert(3,"Karin");
            nomes.Insert(5,"Kisame");

            foreach (string personagem in nomes)
            {
                Console.WriteLine(personagem);
            }

            Console.WriteLine("\nUsando list.Count: " + nomes.Count());

            string find = nomes.Find(x => x[0] == 'N');
            Console.WriteLine("\nUsando list.Find | primeiro com N: " + find);

            string findLast = nomes.FindLast(x => x[0] == 'N');
            Console.WriteLine("\nUsando list.FindLast | ultimo com N: " + findLast);

            int findIndex = nomes.FindIndex(x => x[0] == 'N');
            Console.WriteLine("\nUsando list.FindIndex | posição da primeira ocorrencia com N: " + findIndex);

            int findLastIndex = nomes.FindLastIndex(x => x[0] == 'N');
            Console.WriteLine("\nUsando list.FindLastIndex | posição da ultima ocorrencia com N: "+ findLastIndex);

            List<string> nomesCom5Letras = nomes.FindAll(x => x.Length == 6);
            Console.WriteLine("\nUsando list.FindAll | pegando nomes que possuam 6 letras: \n");
            foreach (var item in nomesCom5Letras)
            {
                Console.WriteLine(item);
            }

            nomes.Remove("Naruto");
            Console.WriteLine("\nUsando list.Remove | removendo o naruto: \n");
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            nomes.RemoveAll(x => x[0] == 'K');
            Console.WriteLine("\nUsando list.RemoveAll | removendo todos que começam com K:\n");
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            nomes.RemoveAt(2);
            Console.WriteLine("\nUsando list.RemoveAt | removendo o item na posição 2:\n");
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            nomes.RemoveRange(2, 4);
            Console.WriteLine("\nUsando list.RemoveRange | Removendo 4 elementos apos a 2 posição: \n");
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
        }

    }
}
