using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao13.Extantisons
{
    public static class StringExtensions
    {
        public static string Cut(this string obj, int count)
        {
            if(obj.Length <= count)
                return obj;

            return obj.Substring(0, count) + "...";
        }
    }
}
