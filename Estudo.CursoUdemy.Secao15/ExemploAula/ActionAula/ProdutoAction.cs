using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao15.ExemploAula.ActionAula
{
    public class ProdutoAction
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public ProdutoAction(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public ProdutoAction(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 1;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantidade + " unidades, Total:  $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
