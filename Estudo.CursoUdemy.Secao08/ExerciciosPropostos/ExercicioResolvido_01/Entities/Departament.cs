using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioResolvido_01.Entities
{
    public class Departament
    {
        public string Name { get; set; }

        public Departament(){ }

        public Departament(string name)
        {
            Name = name;
        }
    }
}
