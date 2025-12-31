using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.Exercicios.ExercicioLerCSV
{
    public class ProdutoCSV
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public ProdutoCSV(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public ProdutoCSV()
        {
        }
    }
}
