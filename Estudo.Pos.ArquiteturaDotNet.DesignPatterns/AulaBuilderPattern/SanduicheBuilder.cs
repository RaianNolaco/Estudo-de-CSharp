using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Pos.ArquiteturaDotNet.DesignPatterns.AulaBuilderPattern
{
    public class SanduicheBuilder
    {
        private string _pao;
        private string _carne;
        private string _queijo;
        private bool _temSalada; 


        public SanduicheBuilder SetPao(string pao)
        {
            this._pao = pao;
            return this;
        }
        public SanduicheBuilder SetCarne(string carne)
        {
            this._carne = carne;
            return this;
        }
        public SanduicheBuilder SetQueijo(string queijo)
        {
            this._queijo = queijo;
            return this;
        }
        public SanduicheBuilder SetPao(bool temSalada)
        {
            this._temSalada = temSalada;
            return this;
        }

        public Sanduiche Build()
        {
            var sanduiche = new Sanduiche(_pao, _carne,_queijo,_temSalada);
            return sanduiche;

        }
    }
}
