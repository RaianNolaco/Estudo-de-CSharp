using Estudo.CursoUdemy.POO_1.AulasExemplos;
using Estudo.CursoUdemy.POO_1.ExerciciosPropostos;
using System;
using System.IO;

namespace Estudo.CursoUdemy.POO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                TrianguloAulaMetodos.TrianguloAula41Metodos();
                Console.WriteLine("================================");
                File.Delete(@"C:\Users\chave\OneDrive\Área de Trabalho\Chantagem amigos\Arquivo.txt");
            } 
        }
    }
}