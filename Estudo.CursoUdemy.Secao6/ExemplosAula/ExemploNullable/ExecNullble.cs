using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.ExemplosAula.ExemploNullable
{
    class ExecNullble
    {
    }using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao6.AulasExemplos.ExemploNullable
    {
        class ExecNullable
        {
            public static void executar()
            {
                //double n1 = null;
                Nullable<double> n1 = null;

                double? n2 = 10.30;

                Console.WriteLine(n1.GetValueOrDefault());
                Console.WriteLine(n2.GetValueOrDefault());

                Console.WriteLine(n1.HasValue);
                Console.WriteLine(n2.HasValue);


                if (!n1.HasValue)
                    Console.WriteLine("N1 é Nulo");

                if (!n2.HasValue)
                    Console.WriteLine("N2 é Nulo");


                // Console.WriteLine(n1.Value);
                // Console.WriteLine(n2.Value);

                double? x = null;
                double? y = 10;

                double a = x ?? 5;
                double b = y ?? 30;

                Console.WriteLine(a);
                Console.WriteLine(b);


                string nome = null;
                string nomeExiste = nome ?? "Nome não existente";

                Console.WriteLine(nome);
                Console.WriteLine(nomeExiste);

            }
        }
    }
}
