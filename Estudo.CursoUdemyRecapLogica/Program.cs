using Estudo.CursoUdemy.RecapLogica.ExemplosAulas;
using Estudo.CursoUdemy.RecapLogica.ExercicosAulas.ExerciciosPropostos;
using System;

namespace Estudo.CursoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ExerciciosFor.quadradoECubo();    
                Console.WriteLine("\n=====================================================\n");
            }
        }
        static void locura()
        {
            double n1 = 0.1;
            float n2 = 0.2f;

            double d1 = 0.1;
            double d2 = 0.2;

            float f1 = 0.1f;
            float f2 = 0.2f;


            bool bl = 9007199254740994 == 9007199254740994;

            Console.WriteLine("Double:  " + (d1 + d2));
            Console.WriteLine("float: " + (f1 + f2));
            Console.WriteLine("Double + Float:  " + (n1 + n2));
        }
    }
}
