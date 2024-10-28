using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.FROMS.Class
{
    internal class Compra
    {
        int CompraID {  get; set; }
        int FonecedorID { get; set; }
        DateTime DataCompra { get; set; }
        decimal TotalCompra { get; set; }
        List<ItemCompra> ItensCompra { get; set; }
    }
}
