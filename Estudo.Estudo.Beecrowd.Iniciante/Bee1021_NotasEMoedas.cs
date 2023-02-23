using System;
using System.Globalization;

namespace Estudo.Estudo.Beecrowd.Iniciante
{
    public static class Bee1021_NotasEMoedas
    {
        public static void executar()
        {
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            int qntNotaCem = 0 , qntNotaCinquenta = 0 , qntNotaVinte = 0, qntNotaDez = 0, qntNotaCinco = 0, qntNotaDois = 0;
            int qntMoedaCem = 0 , qntMoedaCinquenta = 0, qntMoedaVinteCinco = 0, qntMoedaDez = 0, qntMoedaCinco = 0, qntMoedaUm = 0;

                while (valor >= 100)
                {
                    valor -= 100;
                    qntNotaCem++;                 
                }

                while (valor >= 50)
                {
                    valor -= 50;
                    qntNotaCinquenta++;
                }

                while (valor >= 20)
                {
                    valor -= 20;
                    qntNotaVinte++;
                }

                while (valor >= 10)
                {
                    valor -= 10;
                    qntNotaDez++;
                }

                while (valor >= 5)
                {
                    valor -= 5;
                    qntNotaCinco++;
                }

                while (valor >= 2)
                {
                    valor -= 2;
                    qntNotaDois++;
                }


                while (valor >= 1)
                {
                    valor -= 1;
                    qntMoedaCem++;
                }
                while (valor >= 0.50)
                {
                    valor -= 0.50;
                    qntMoedaCinquenta++;
                }

                while (valor >= 0.25)
                {
                    valor -= 0.25;
                    qntMoedaVinteCinco++;
                }

                while (valor >= 0.10)
                {
                    valor -= 0.10;
                    qntMoedaDez++;
                }

                while (valor >= 0.05)
                {
                    valor -= 0.05;
                    qntMoedaCinco++;
                }

                while (valor >= 0.01)
                {
                    valor -= 0.01;
                    qntMoedaUm++;
            }

            Console.WriteLine("\nNOTAS:"
            + $"\n{qntNotaCem} nota(s) de R$ 100.00"
            + $"\n{qntNotaCinquenta} nota(s) de R$ 50.00"
            + $"\n{qntNotaVinte} nota(s) de R$ 20.00"
            + $"\n{qntNotaDez} nota(s) de R$ 10.00"
            + $"\n{qntNotaCinco} nota(s) de R$ 5.00"
            + $"\n{qntNotaDois} nota(s) de R$ 2.00"
            + $"\nMOEDAS:"
            + $"\n{qntMoedaCem} moeda(s) de R$ 1.00"
            + $"\n{qntMoedaCinquenta} moeda(s) de R$ 0.50"
            + $"\n{qntMoedaVinteCinco} moeda(s) de R$ 0.25"
            + $"\n{qntMoedaDez} moeda(s) de R$ 0.10"
            + $"\n{qntMoedaCinco} moeda(s) de R$ 0.05"
            + $"\n{qntMoedaUm} moeda(s) de R$ 0.01");

        }

        public static void robo()
        {
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // notas
            int cem = (int)valor / 100;
            valor %= 100.0;
            int cinquenta = (int)valor / 50;
            valor %= 50.0;
            int vinte = (int)valor / 20;
            valor %= 20.0;
            int dez = (int)valor / 10;
            valor %= 10.0;
            int cinco = (int)valor / 5;
            valor %= 5.0;
            int dois = (int)valor / 2;
            valor %= 2.0;

            // moedas
            int um = (int)valor / 1;
            valor %= 1.0;
            int cinquentaCent = (int)(valor / 0.5);
            valor %= 0.5;
            int vinteECincoCent = (int)(valor / 0.25);
            valor %= 0.25;
            int dezCent = (int)(valor / 0.1);
            valor %= 0.1;
            int cincoCent = (int)(valor / 0.05);
            valor %= 0.05;
            int umCent = (int)(valor / 0.01);

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{cem} nota(s) de R$ 100.00");
            Console.WriteLine($"{cinquenta} nota(s) de R$ 50.00");
            Console.WriteLine($"{vinte} nota(s) de R$ 20.00");
            Console.WriteLine($"{dez} nota(s) de R$ 10.00");
            Console.WriteLine($"{cinco} nota(s) de R$ 5.00");
            Console.WriteLine($"{dois} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{um} moeda(s) de R$ 1.00");
            Console.WriteLine($"{cinquentaCent} moeda(s) de R$ 0.50");
            Console.WriteLine($"{vinteECincoCent} moeda(s) de R$ 0.25");
            Console.WriteLine($"{dezCent} moeda(s) de R$ 0.10");
            Console.WriteLine($"{cincoCent} moeda(s) de R$ 0.05");
            Console.WriteLine($"{umCent} moeda(s) de R$ 0.01");
        }
    }
}
