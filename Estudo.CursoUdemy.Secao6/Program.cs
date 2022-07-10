using Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploVetor;
using Estudo.CursoUdemy.Secao6.Struct;
using System;

namespace Estudo.CursoUdemy.Secao6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
              //  ExecVetorParte2.produtos();
                exercicos();

                Console.WriteLine("===================================================");
                //Console.ReadLine();
            }

        }

        static void exercicos()
        {
            int idade = int.Parse(Console.ReadLine());

            int qntAnos  = 0;
            int qntMeses = 0;

            while (idade >= 365)
            {
                idade -= 365;
                qntAnos++;
            }
            while (idade >= 30)
            {
                idade -= 30;
                qntMeses++;
            }

            Console.WriteLine($"{qntAnos} ano (s)\n{qntMeses} mes (es)\n{idade} dia (s)");
        }
    }
}
