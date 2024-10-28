using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.FROMS.Metodos
{
    public static class DateTimeExtensions
    {
        public static string FormatarMesAno(this DateTime data)
        {
            return data.ToString("MMMM yyyy");
        }
    }
}
