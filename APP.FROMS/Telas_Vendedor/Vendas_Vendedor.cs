using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.FROMS.Telas_Vendedor
{
    public partial class Vendas_Vendedor : Form
    {
        Metodos.SetVendad set = new Metodos.SetVendad();
        DataTable vendas;
        public Vendas_Vendedor()
        {
            InitializeComponent();
        }

        private void Vendas_Vendedor_Load(object sender, EventArgs e)
        {
            vendas = set.Vendas();
            dtGrid_Vendas.DataSource = vendas;

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
