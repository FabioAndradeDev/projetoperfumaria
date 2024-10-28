using System;
using System.Globalization;

namespace APP.FROMS.Class
{
    public class RelatorioDetalhado
    {
        public DateTime Mes { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataCompra { get; set; }
        public int EstoqueAtual { get; set; }
        public decimal TotalVenda { get; set; }
        public decimal TotalCompra { get; set; }
        public decimal Lucro { get; set; }
    }

    public static class DateTimeExtensions
    {
        public static string FormatarMesAno(this DateTime data)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(data.Month) + " " + data.Year;
        }
    }
}
