using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploMatrizes
{
    class ExecMatriz
    {
        public static void Execultar()
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine("Usando mat.Length: "+mat.Length);
            Console.WriteLine("Usando mat.Rank: " + mat.Rank);
            Console.WriteLine("Usando mat.GetLength(0): " + mat.GetLength(0));
            Console.WriteLine("Usando mat.GetLength(1): " + mat.GetLength(1));

            Console.WriteLine(mat);
        }
    }
}
