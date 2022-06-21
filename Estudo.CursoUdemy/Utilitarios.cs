using System;
using System.Collections.Generic;
using System.Globalization;

namespace Estudo.CursoUdemy.RecapLogica
{
    public class Utilitarios
    {
        public static int pedirNumeroInteiro(string txt = null)
        {
            if (txt == null)
            {
                Console.Write("Digite um numero inteiro: ");
            }
            else
            {
                Console.Write(txt);
            }
            
            int n1 = int.Parse(Console.ReadLine());

            return n1;
        }
        public static double pedirNumeroDecimal(string txt = null)
        {
            if (txt == null)
            {
                Console.WriteLine("Digite um numero: ");
            }
            else
            {
                Console.WriteLine(txt);
            }
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return n1;
        }
        public static List<int> pedirDoisNumerosInteiros()
        {
            Console.WriteLine("Digite dois numeros interios na mesma linha");
            string[] listaNumero = Console.ReadLine().Split(' ');

            List<int> valores = new List<int> { };

            valores.Add(int.Parse(listaNumero[0]));
            valores.Add(int.Parse(listaNumero[1]));

            return valores;
        }
        public static List<double> pedirDoisNumerosDecimais()
        {
            Console.WriteLine("Digite dois numeros na mesma linha");
            string[] listaNumero = Console.ReadLine().Split(' ');

            List<double> valores = new List<double> { };

            valores.Add(double.Parse(listaNumero[0], CultureInfo.InvariantCulture));
            valores.Add(double.Parse(listaNumero[1], CultureInfo.InvariantCulture));

            return valores;
        }
        public static List<double> pedirNumerosDecimais(int qntNumeros, string txt = null)
        {
            if(txt == null)
            {
                Console.Write($"Digite {qntNumeros} numeros na mesma linha: ");
            }
            else
            {
                Console.Write(txt);
            }
            string[] listaNumero = Console.ReadLine().Split(' ');

            List<double> valores = new List<double> { };
            for(int i = 0; i <= (qntNumeros-1);i++)
            {
                valores.Add(double.Parse(listaNumero[i], CultureInfo.InvariantCulture));
            }

            return valores;
        }
    }
}