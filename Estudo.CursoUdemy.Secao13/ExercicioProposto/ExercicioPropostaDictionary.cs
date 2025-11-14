using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao13.ExercicioProposto
{
    public static class ExercicioPropostaDictionary
    {
        static string path = @"C:\temp\in.txt";
        public static void executar()
        {

            var pathTxt = pedirCaminho();

            var votos = extrairVotos(pathTxt);

            foreach (var voto in votos) {
                Console.WriteLine($"{voto.Key}: {voto.Value}");          
            }
        }
        

        private static Dictionary<string, int> extrairVotos(string pathTxt)
        {
             while (!File.Exists(pathTxt))
            {
                Console.WriteLine("invalid path");
                pathTxt = pedirCaminho();
            }

            Dictionary<string, int> votos = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(pathTxt))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] keyValue = sr.ReadLine().Split(",");

                        string key = keyValue[0];
                        int value = int.Parse(keyValue[1]);

                        if (votos.ContainsKey(key))
                        {
                            votos[key] += value;
                        }
                        else
                        {
                            votos.Add(key, value);
                        }
                    }

                    return votos;

                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private static string pedirCaminho()
        {
            Console.Write("Enter file full path: ");
            var pathTxt = Console.ReadLine();

            
            return pathTxt;
        }
    }
}
