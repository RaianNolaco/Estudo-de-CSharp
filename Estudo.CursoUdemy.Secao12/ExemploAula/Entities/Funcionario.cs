using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estudo.CursoUdemy.Secao12.ExemploAula.Entities
{
    public class Funcionario: IComparable
    {
        public string? Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string csv) {
            string[] vect = csv.Split(',');
            Nome = vect[0];
            Salario = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Nome +", "+ Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Funcionario))
                throw new ArgumentException("Apenas funcionarios");

            Funcionario outro = obj as Funcionario;
            return Salario.CompareTo(outro.Salario);
        }
    }
}
