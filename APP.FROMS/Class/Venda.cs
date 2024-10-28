using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.FROMS.Class
{
    internal class Venda
    {
        int VendaID { get; set; }
        int UsuarioID { get; set; }
        DateTime DataVenda { get; set; }
        decimal TotalVenda { get; set; }
        List<ItemVenda> ItensVendas { get; set; }
    }
}
