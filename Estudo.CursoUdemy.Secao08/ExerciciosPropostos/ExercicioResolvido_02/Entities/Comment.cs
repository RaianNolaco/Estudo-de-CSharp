using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioResolvido_02.Entities
{
    public  class Comment
    {
        public string Text { get; set; }

        public Comment()
        {

        }
        public Comment(string text)
        {
            Text = text;
        }
    }
}
