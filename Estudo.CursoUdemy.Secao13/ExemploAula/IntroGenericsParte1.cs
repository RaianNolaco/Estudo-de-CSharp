using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao13.ExemploAula
{
    public static class IntroGenericsParte1
    {
        public static void executar()
        {
            PrintServiceGeneric<int> print = new PrintServiceGeneric<int>();

            Console.Write("How many values? ");
            int qntValues = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qntValues; i++) {
                int value = Convert.ToInt32(Console.ReadLine());
                print.addValue(value);
            }

            print.print();
            print.first();

            PrintServiceGeneric<string> printString = new PrintServiceGeneric<string>();

            Console.Write("How many values? ");
            int qntValues2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qntValues; i++) {
                string value = Console.ReadLine();
                printString.addValue(value);
            }

            printString.print();
            printString.first();

            print.dataType(); 
            printString.dataType();
        }
    }
}
