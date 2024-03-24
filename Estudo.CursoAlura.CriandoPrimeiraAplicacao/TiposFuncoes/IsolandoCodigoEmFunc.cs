using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoAlura.CriandoPrimeiraAplicacao
{
    internal class IsolandoCodigoEmFunc
    {
        static string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

        public static void Excutar()
        {
            ExibirMensagemDeBoasVindas();
        }

        static void ExibirMensagemDeBoasVindas()
        {
            Console.WriteLine("**************************");
            Console.WriteLine(mensagemDeBoasVindas);
            Console.WriteLine("**************************");
        }

    }
}
