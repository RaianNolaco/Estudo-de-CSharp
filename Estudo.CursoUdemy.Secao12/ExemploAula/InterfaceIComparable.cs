using Estudo.CursoUdemy.Secao12.ExemploAula.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao12.ExemploAula
{
    public static class InterfaceIComparable
    {
        public static void executar()
        {
            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> list = new List<Funcionario>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (Funcionario item in list)
                    {
                        Console.WriteLine(item);
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
        }
    }
}
