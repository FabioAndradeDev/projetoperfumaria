using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.FROMS.Class
{
    internal class ItemCompra
    {
        int ItemCompraID { get; set; }
        int CompraID { get; set; }  
        int ProdutoID { get; set; }
        int Quantidade { get; set; }
        decimal PrecoUnitario { get; set; } 
    }
}
