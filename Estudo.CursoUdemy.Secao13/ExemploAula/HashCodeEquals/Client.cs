using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao13.ExemploAula.HashCodeEquals
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is Client))
                return false;          

            Client? other = obj as Client;
            var result =  Email.Equals(other.Email);
            return result;
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
