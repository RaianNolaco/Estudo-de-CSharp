﻿using System.Globalization;

namespace Estudo.CursoUdemy.POO_1.AulasExemplos.ExemploProduto.Classe
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque(){
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
