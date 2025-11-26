using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao13.Extantisons
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime obj)
        {
            TimeSpan duration = DateTime.Now.Subtract(obj);

            if(duration.TotalHours < 24.0)
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";

            return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
        }
    }
}
