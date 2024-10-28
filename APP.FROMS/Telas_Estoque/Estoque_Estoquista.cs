using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using APP.FROMS.Metodos;
using APP.FROMS.Telas;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.FROMS.Telas;

namespace APP.FROMS.Telas_Estoque
{
    public partial class Estoque_Estoquista : Form
    {
        Metodos.DataSet set = new Metodos.DataSet();
        DataTable estoque;

        public Estoque_Estoquista()
        {
            InitializeComponent();
        }

        private void Estoque_Estoquista_Load(object sender, EventArgs e)
        {
            estoque = set.Estoque();
            dtGrid_Estoque.DataSource = estoque;

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
         
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            registrarProdutocs registrarProduto = new registrarProdutocs();
            registrarProduto.Show();
            this.Hide();
            Estoque estoque = new Estoque();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            RemoçãodeProduto remoçãodeProduto = new RemoçãodeProduto();
            remoçãodeProduto.Show();
            this.Hide();
        }
    }
}
